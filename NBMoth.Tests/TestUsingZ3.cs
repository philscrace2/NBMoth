using Microsoft.Z3;
using NUnit.Framework;
using System.Collections.Generic;
using NBMoth.Backend.z3;
using NBMoth.Parser;

namespace NBMoth.Tests {

    //    package de.bmoth;

    //    import com.microsoft.z3.BoolExpr;
    //    import com.microsoft.z3.Context;
    //    import com.microsoft.z3.Solver;
    //    import com.microsoft.z3.Status;
    //    import de.bmoth.backend.z3.FormulaToZ3Translator;
    //    import de.bmoth.parser.ParserException;

    //    import org.junit.After;
    //    import org.junit.Before;

    //    import java.util.Map;

    //    import static org.junit.Assert.assertEquals;
    //import static org.junit.Assert.fail;

    public class TestUsingZ3
    {
        protected Context z3Context;
        protected Solver z3Solver;

        [SetUp]
        public void setup()
        {
            z3Context = new Context();
            z3Solver = z3Context.MkSolver();
        }
        [TearDown]
        public void cleanup()
        {
            // z3Context.Close()
        }

        public static BoolExpr translatePredicate(string formula, Context z3Context)
        {
            try
            {
                return FormulaToZ3Translator.translatePredicate(formula, z3Context);
            }
            catch (ParserException e)
            {
                Assert.Fail(e.getMessage());
                return null;
            }
        }

        public void check(Status satisfiable, string formula)
        {
            BoolExpr constraint = translatePredicate(formula, z3Context);
            // create scope just for current constraint
            z3Solver.Push();
            z3Solver.Add(constraint);
            Status check = z3Solver.Check();
            // clean solver stack
            z3Solver.Pop();
            Assert.Equals(satisfiable, check);
        }

        protected void checkLaw(string law)
        {
            BoolExpr constraint = translatePredicate(law, z3Context);
            z3Solver.Push();
            z3Solver.Add(z3Context.MkNot(constraint));
            Status check = z3Solver.Check();
            z3Solver.Pop();
            Assert.Equals(Status.UNSATISFIABLE, check);
        }

        protected void checkTruthTable(Dictionary<string, Status> map)
        {
            foreach (var entry in map)
            {
                check(entry.Value, entry.Key);
                z3Solver.Reset();
            }
        }
    }



}