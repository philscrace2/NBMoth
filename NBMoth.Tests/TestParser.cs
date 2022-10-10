using NBMoth.Parser.ast;

namespace NBMoth.Tests{

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
                return Parser.getLTLFormulaAsSemanticAst(formula);
            }
            catch (ParserException e)
            {
                fail(e.getMessage());
                return null;
            }
        }

        public static FormulaNode parseFormula(string formula)
        {
            try
            {
                return Parser.getFormulaAsSemanticAst(formula);
            }
            catch (ParserException e)
            {
                fail(e.getMessage());
                return null;
            }
        }

        public static MachineNode parseMachine(string machine)
        {
            try
            {
                return Parser.getMachineAsSemanticAst(machine);
            }
            catch (ParserException e)
            {
                fail(e.getMessage());
                return null;
            }
        }

        public static MachineNode parseMachineFromFile(string file)
        {
            try
            {
                return Parser.getMachineFileAsSemanticAst(file);
            }
            catch (ParserException e)
            {
                fail(e.getMessage());
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
            private List<string> operations = new ArrayList<>();

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
                this.operations.add(operation);
                return this;
            }


            public MachineNode build()
            {
                return parseMachine(this.tostring());
            }

            @Override
            public string tostring()
            {
                stringBuilder sb = new stringBuilder();
                sb.append("MACHINE ").append(name).append("\n");
                if (!definitions.isEmpty())
                {
                    sb.append("DEFINITIONS ").append(definitions).append("\n");
                }
                if (!sets.isEmpty())
                {
                    sb.append("SETS ").append(sets).append("\n");
                }
                if (!variables.isEmpty())
                {
                    sb.append("VARIABLES ").append(variables).append("\n");
                }
                if (!properties.isEmpty())
                {
                    sb.append("PROPERTIES ").append(properties).append("\n");
                }
                if (!invariant.isEmpty())
                {
                    sb.append("INVARIANT ").append(invariant).append("\n");
                }
                if (!initialization.isEmpty())
                {
                    sb.append("INITIALISATION ").append(initialization).append("\n");
                }

                if (!operations.isEmpty())
                {
                    sb.append("OPERATIONS\n");
                    for (Iterator<string> op = operations.iterator(); op.hasNext();)
                    {
                        string operation = op.next();
                        sb.append("\t").append(operation).append(op.hasNext() ? ";\n" : "\n");
                    }
                }
                sb.append("END");
                return sb.tostring();
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

        public class CycleComparator<E extends Object> {
        private readonly Set<Set<string>> expected;
        private readonly Set<Set<string>> actual;


        public CycleComparator()
        {
            expected = new HashSet<>();
            actual = new HashSet<>();
        }

        public void addExpectedCycle(string...values)
        {
            expected.add(new HashSet<>(Arrays.asList(values)));
        }

        public void addActualCycle(Collection<? extends E> values)
        {
            actual.add(values.stream().map(E::tostring).collect(Collectors.toSet()));
        }

        public void compare()
        {
            Set<Set<string>> unvisitedExpexted = new HashSet<>(expected);

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
                    fail("Didn't find: " + currentActual);
                }
            }

            if (!unvisitedExpexted.isEmpty())
            {
                fail("Didn't visit expected: " + unvisitedExpexted.tostring());
            }
        }
    }
}


}