using NBMoth.Parser.ast;
using NBMoth.Parser.ast.nodes.ltl;
using NBMoth.Parser.ast.nodes;
using NBMoth.Parser;
using Parser = NBMoth.Parser.Parser;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;

namespace NBMoth.Tests {

    //package de.bmoth;

    //import de.bmoth.parser.Parser;
    //import de.bmoth.parser.ParserException;
    //import de.bmoth.parser.ast.nodes.FormulaNode;
    //import de.bmoth.parser.ast.nodes.MachineNode;
    //import de.bmoth.parser.ast.nodes.ltl.LTLFormula;

    //import java.util.*;
    //import java.util.stream.Collectors;

    //import static org.junit.Assert.fail;

    public class TestParser
    {
        protected TestParser()
        {

        }

        public static LTLFormula parseLtlFormula(string formula)
        {
            try
            {
                return Parser.Parser.getLTLFormulaAsSemanticAst(formula);
            }
            catch (ParserException e)
            {
                Assert.Fail(e.getMessage());
                return null;
            }
        }

        public static FormulaNode parseFormula(string formula)
        {
            try
            {
                return Parser.Parser.getFormulaAsSemanticAst(formula);
            }
            catch (ParserException e)
            {
                Assert.Fail(e.getMessage());
                return null;
            }
        }

        public static MachineNode parseMachine(string machine)
        {
            try
            {
                return Parser.Parser.getMachineAsSemanticAst(machine);
            }
            catch (ParserException e)
            {
                Assert.Fail(e.getMessage());
                return null;
            }
        }

        public static MachineNode parseMachineFromFile(string file)
        {
            try
            {
                return Parser.Parser.getMachineFileAsSemanticAst(file);
            }
            catch (ParserException e)
            {
                Assert.Fail(e.getMessage());
                return null;
            }
        }

        public class MachineBuilder
        {
            private string name = "";
            private string definitions = "";
            private string sets = "";
            private string variables = "";
            private string properties = "";
            private string invariant = "";
            private string initialization = "";
            private List<string> operations = new List<string>();

            public MachineBuilder setName(string name)
            {
                this.name = name;
                return this;
            }

            public MachineBuilder setVariables(string variables)
            {
                this.variables = variables;
                return this;
            }

            public MachineBuilder setInvariant(string invariant)
            {
                this.invariant = invariant;
                return this;
            }

            public MachineBuilder setInitialization(string initialization)
            {
                this.initialization = initialization;
                return this;
            }

            public MachineBuilder addOperation(string operation)
            {
                this.operations.Add(operation);
                return this;
            }


            public MachineNode build()
            {
                return parseMachine(this.Tostring());
            }


            public string Tostring()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("MACHINE ").Append(name).Append("\n");
                if (definitions.Length > 0)
                {
                    sb.Append("DEFINITIONS ").Append(definitions).Append("\n");
                }
                if (sets.Length > 0)
                {
                    sb.Append("SETS ").Append(sets).Append("\n");
                }
                if (variables.Length > 0)
                {
                    sb.Append("VARIABLES ").Append(variables).Append("\n");
                }
                if (properties.Length > 0)
                {
                    sb.Append("PROPERTIES ").Append(properties).Append("\n");
                }
                if (invariant.Length > 0)
                {
                    sb.Append("INVARIANT ").Append(invariant).Append("\n");
                }
                if (initialization.Length > 0)
                {
                    sb.Append("INITIALISATION ").Append(initialization).Append("\n");
                }

                if (operations.Count > 0)
                {
                    sb.Append("OPERATIONS\n");
                    foreach (string op in operations)
                    {
                        //Phil Scrace 
                        sb.Append("\t").Append(op).Append(op.hasNext() ? ";\n" : "\n");
                    }
                }
                sb.Append("END");
                return sb.ToString();
            }

            public MachineBuilder setSets(string sets)
            {
                this.sets = sets;
                return this;
            }

            public MachineBuilder setProperties(string properties)
            {
                this.properties = properties;
                return this;
            }

            public MachineBuilder setDefinitions(string definitions)
            {
                this.definitions = definitions;
                return this;
            }
        }

        public class CycleComparator<T> where T : class
        {
            private readonly HashSet<string> expected;
            private readonly HashSet<string> actual;


            public CycleComparator()
            {
                expected = new HashSet<string>();
                actual = new HashSet<string>();
            }

            public void addExpectedCycle(string values)
            {
                expected.Add(new HashSet<string>(values));
            }

            public void addActualCycle(Collection<? extends E> values)
            {
                actual.Add(values.stream().Map(E::tostring).collect(Collectors.toSet()));
            }

            public void compare()
            {
                Set<Set<string>> unvisitedExpexted = new HashSet<string>(expected);

                for (Set<string> currentActual : actual)
                {
                    boolean found = false;
                    for (Set<string> currentExpected : expected)
                    {
                        if (currentActual.size() == currentExpected.size())
                        {
                            if (currentActual.containsAll(currentExpected))
                            {
                                found = true;
                                unvisitedExpexted.remove(currentExpected);
                                break;
                            }
                        }
                    }
                    if (!found)
                    {
                        Assert.Fail("Didn't find: " + currentActual);
                    }
                }

                if (!unvisitedExpexted.isEmpty())
                {
                    Assert.Fail("Didn't visit expected: " + unvisitedExpexted.tostring());
                }
            }
        }
    }
}


