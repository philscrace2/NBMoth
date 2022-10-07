using System;
using NUnit.Framework;
using Microsoft.Z3;


namespace NBMoth.Tests.backend.connection {

    


    //package de.bmoth.backend.connection;

    //import com.microsoft.z3.BoolExpr;
    //import com.microsoft.z3.Expr;
    //import com.microsoft.z3.Status;
    //import de.bmoth.TestUsingZ3;
    //import org.junit.Test;

    //import static org.junit.Assert.assertEquals;


    public class Z3ConnectionTest : TestUsingZ3
    {
        


        [Test]
        public void testSimpleCallToZ3()
        {
            // a = b & a = 5
            Expr a = z3Context.MkIntConst("a");            
            Expr b = z3Context.mkIntConst("b");
            BoolExpr constraint = z3Context.mkAnd(z3Context.mkEq(a, b), z3Context.mkEq(a, z3Context.mkInt(5)));
            z3Solver.add(constraint);
            Status check = z3Solver.check();

            Assert.Equals(Status.SATISFIABLE, check);
            Assert.Equals(z3Context.mkInt(5), z3Solver.getModel().eval(a, true));
            Assert.Equals(z3Context.mkInt(5), z3Solver.getModel().eval(b, true));
        }

        [Test]
        public void testQuantifiedFormula()
        {
            Expr a = z3Context.mkIntConst("a");
            Expr b = z3Context.mkIntConst("b");
            BoolExpr constraint = z3Context.mkAnd(z3Context.mkEq(a, b), z3Context.mkEq(a, z3Context.mkInt(5)), z3Context.mkEq(b, z3Context.mkInt(7)));
            constraint = z3Context.mkExists(new Expr[] { a, b }, constraint, 1, null, null, null, null);

            z3Solver.add(constraint);
            Status check = z3Solver.check();

            Assert.Equals(Status.UNSATISFIABLE, check);
        }

    }


}

