using System.Collections.Generic;
using Antlr4.Runtime;

namespace NBMoth.Parser {

    //import java.util.ArrayList;
    //import java.util.List;

    //import org.antlr.v4.runtime.ParserRuleContext;
    //import org.antlr.v4.runtime.Token;

    //import de.bmoth.antlr.BMoThParser;
    //import de.bmoth.antlr.BMoThParserBaseVisitor;
    //import de.bmoth.antlr.BMoThParser.PredicateContext;
    //import de.bmoth.antlr.BMoThParser.PredicateOperatorContext;

    public class CSTAnalyser
    {

        public static List<string> analyseConcreteSyntaxTree(ParserRuleContext tree)
        {
            CSTAnalyser cstAnalyser = new CSTAnalyser();
            CSTVisitor cstVisitor = new CSTVisitor();
            cstVisitor.visit(tree);
            return cstAnalyser.warnings;
        }

        private List<string> warnings = new List<string>();

        class CSTVisitor : BMoThParserBaseVisitor<Void> {
            
        public void visitPredicateOperator(PredicateOperatorContext ctx)
        {
            checkForAmbiguousOperatorCombination(ctx, BMoThParser.AND, BMoThParser.OR);
            checkForAmbiguousOperatorCombination(ctx, BMoThParser.OR, BMoThParser.AND);
            return null;
        }

        private void checkForAmbiguousOperatorCombination(PredicateOperatorContext ctx, int op1, int op2)
        {
            if (ctx.operator.getType() == op1) {
                for (PredicateContext predicateContext : ctx.predicate())
                {
                    if (predicateContext instanceof BMoThParser.PredicateOperatorContext) {
                    PredicateOperatorContext predicateOperator = (BMoThParser.PredicateOperatorContext)predicateContext;
                    if (predicateOperator.operator.getType() == op2) {
                        Token operator1 = ctx.operator;
                        Token operator2 = predicateOperator.operator;
                        /*
                         * e.g. TRUE or FALSE & FALSE, then operator1 is '&'
                         * and operator2 is 'or'
                         */
                        addWarning(String.format(
                                "Ambiguous combination of operators '%s' (line %s, pos %s) and '%s' (line %s, pos %s)."
                                        + " Use parentheses to avoid this.",
                                operator2.getText(), operator2.getLine(), operator2.getCharPositionInLine(),
                                operator1.getText(), operator1.getLine(), operator1.getCharPositionInLine()));
                    }
                }
            }
        }
    }

    private void addWarning(string s)
    {
        warnings.add(s);
    }

}

}



}