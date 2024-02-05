using System.Collections.Generic;
using System.Text;
using NBMoth.Parser.ast.nodes;
using NBMoth.Parser.ast;
using FormulaNode = NBMoth.Parser.ast.nodes.FormulaNode;
using NBMoth.Parser.ast.nodes.ltl;
using NBMoth.Antlr;
using FormulaContext = NBMoth.Antlr.NBMothParser.FormulaContext;
using LtlStartContext = NBMoth.Antlr.NBMothParser.LtlStartContext;
using StartContext = NBMoth.Antlr.NBMothParser.StartContext;


namespace NBMoth.Parser
{

    //package de.bmoth.parser;

    //import de.bmoth.antlr.BMoThLexer;
    //import de.bmoth.antlr.BMoThParser;
    //import de.bmoth.antlr.BMoThParser.FormulaContext;
    //import de.bmoth.antlr.BMoThParser.LtlStartContext;
    //import de.bmoth.antlr.BMoThParser.StartContext;
    //import de.bmoth.parser.ErrorListener.VisitorException;
    //import de.bmoth.parser.ast.SemanticAstCreator;
    //import de.bmoth.parser.ast.TypeChecker;
    //import de.bmoth.parser.ast.TypeErrorException;
    //import de.bmoth.parser.ast.nodes.FormulaNode;
    //import de.bmoth.parser.ast.nodes.MachineNode;
    //import de.bmoth.parser.ast.nodes.ltl.LTLFormula;
    //import de.bmoth.parser.cst.*;

    //import org.antlr.v4.runtime.CharStreams;
    //import org.antlr.v4.runtime.CodePointCharStream;
    //import org.antlr.v4.runtime.CommonTokenStream;

    //import java.io.File;
    //import java.io.FileInputStream;
    //import java.io.IOException;
    //import java.io.InputStreamReader;
    //import java.nio.charset.Charset;
    //import java.util.List;
    //import java.util.logging.Level;
    //import java.util.logging.Logger;

    public class Parser
    {

        private static readonly string PARSE_ERROR = "PARSE_ERROR";

        public static FormulaNode getFormulaAsSemanticAst(string inputstring)
        {
            Parser parser = new Parser();
            try
            {
                FormulaContext formulaContext;
                formulaContext = parser.parseFormula(inputstring);
                List<string> warnings = CSTAnalyser.analyseConcreteSyntaxTree(formulaContext);
                FormulaNode formulaNode = parser.getFormulaAst(formulaContext);
                formulaNode.setWarnings(warnings);
                TypeChecker.typecheckFormulaNode(formulaNode);
                return formulaNode;
            }
            catch (ParseErrorException | TypeErrorException | ScopeException e) {
                throw new ParserException(e);
            }
            }
        }

        private NBMothParser getParser(string inputstring)
        {
            CodePointCharStream fromstring = CharStreams.fromstring(inputstring);
            NBMothLexer lexer = new NBMothLexer(fromstring);
            // create a buffer of tokens pulled from the lexer
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            NBMothParser bMoThParser = new NBMothParser(tokens);
            bMoThParser.removeErrorListeners();
            ErrorListener errorListener = new ErrorListener();
            bMoThParser.addErrorListener(errorListener);
            return bMoThParser;
        }

        private StartContext parseMachine(string inputstring)
        {
            NBMothParser parser = getParser(inputstring);
            try
            {
                return parser.start();
            }
            catch (VisitorException e)
            {
                Logger logger = Logger.getLogger(getClass().getName());
                logger.log(Level.SEVERE, PARSE_ERROR, e);
                throw e.getParseErrorException();
            }
        }

        public static MachineNode getMachineAsSemanticAst(string inputstring) // throws ParserException
        {
            Parser parser = new Parser();
            try
            {
                StartContext start = parser.parseMachine(inputstring);
                List<string> warnings = CSTAnalyser.analyseConcreteSyntaxTree(start);
                MachineNode machineNode = parser.getMachineAst(start);
                machineNode.setWarnings(warnings);
                TypeChecker.typecheckMachineNode(machineNode);
                return machineNode;
            }
            catch (ParseErrorException | TypeErrorException | ScopeException e) {
                throw new ParserException(e);
            }

            }
        }


        private FormulaContext parseFormula(string inputstring)
        {
            NBMothParser parser = getParser(inputstring);
            try {
                return parser.formula();
            } catch (VisitorException e) {
                final Logger logger = Logger.getLogger(getClass().getName());
                logger.log(Level.SEVERE, PARSE_ERROR, e);
                throw e.getParseErrorException();
            }
        }

        private LtlStartContext parseLTLFormula(string inputstring)
        {
            CodePointCharStream fromstring = CharStreams.fromstring(inputstring);
            final BMoThLexer lexer = new BMoThLexer(fromstring);
            lexer.pushMode(BMoThLexer.LTL_MODE);
            // create a buffer of tokens pulled from the lexer
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            BMoThParser parser = new BMoThParser(tokens);
            parser.removeErrorListeners();
            ErrorListener errorListener = new ErrorListener();
            parser.addErrorListener(errorListener);

            try
            {
                return parser.ltlStart();
            }
            catch (VisitorException e)
            {
                final Logger logger = Logger.getLogger(getClass().getName());
                logger.log(Level.SEVERE, PARSE_ERROR, e);
                throw e.getParseErrorException();
            }
        }

        public static LtlStartContext getLTLFormulaAsCST(string string)
        {
            Parser parser = new Parser();
            return parser.parseLTLFormula(string);
        }

        private MachineNode getMachineAst(StartContext start)
        {
            MachineAnalyser machineAnalyser = new MachineAnalyser(start);
            SemanticAstCreator astCreator = new SemanticAstCreator(machineAnalyser);
            return (MachineNode)astCreator.getAstNode();
        }

        private FormulaNode getFormulaAst(FormulaContext formula) //throws ScopeException
        {
            FormulaAnalyser formulaAnalyser = new FormulaAnalyser(formula);
            SemanticAstCreator astCreator = new SemanticAstCreator(formulaAnalyser);
            return (FormulaNode)astCreator.getAstNode();
        }

        private LTLFormula getLTLFormulaAst(LtlStartContext context) //throws ScopeException
        {
            LTLFormulaAnalyser formulaAnalyser = new LTLFormulaAnalyser(context);
            SemanticAstCreator astCreator = new SemanticAstCreator(formulaAnalyser);
            return (LTLFormula)astCreator.getAstNode();
        }

        public static MachineNode getMachineFileAsSemanticAst(string file) // throws ParserException
        {
            try
            {
                string fileContent = readFile(new File(file));
                return getMachineAsSemanticAst(fileContent);
            }
            catch (IOException e)
            {
                throw new ParserException(e);
            }
        }

        public static LTLFormula getLTLFormulaAsSemanticAst(string inputstring) // throws ParserException
        {
            Parser parser = new Parser();
            try
            {
                LtlStartContext context;
                context = parser.parseLTLFormula(inputstring);
                LTLFormula ltlFormulaAst = parser.getLTLFormulaAst(context);
                TypeChecker.typecheckLTLFormulaNode(ltlFormulaAst);
                return ltlFormulaAst;
            }
            catch (ParseErrorException | ScopeException | TypeErrorException e) {
                throw new ParserException(e);
            }
            }
        }

        static string readFile(File file)
        {
            try (InputStreamReader inputStreamReader = new InputStreamReader(new FileInputStream(file),
                        Charset.forName("UTF-8"))) 
            {

                StringBuilder builder = new StringBuilder();
                char[] buffer = new char[1024];
                int read;
                while ((read = inputStreamReader.read(buffer)) >= 0)
                {
                    builder.append(string.valueOf(buffer, 0, read));
                }
                string content = builder.tostring();

                if (!content.isEmpty())
                {
                    // remove utf-8 byte order mark
                    // replaceAll \uFEFF did not work for some reason
                    // apparently, unix like systems report a single character with
                    // the
                    // code
                    // below
                    if (content.startsWith("\uFEFF"))
                    {
                        content = content.substring(1);
                    }
                    // while windows splits it up into three characters with the
                    // codes
                    // below
                    else if (content.StartsWith("\u00EF\u00BB\u00BF"))
                    {
                        content = content.Substring(3);
                    }

                    return content.ReplaceAll("\r\n", "\n");
                }
            }
            catch
            {


            }
        }

            
    }
}











        








