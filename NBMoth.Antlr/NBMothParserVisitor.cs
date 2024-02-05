//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\source\nbmoth-parser-only\NBMothAntlr\NBMothParser.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


//package de.bmoth.antlr;

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="NBMothParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface INBMothParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>ParseUnit</c>
	/// labeled alternative in <see cref="NBMothParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParseUnit([NotNull] NBMothParser.ParseUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MachineParseUnit</c>
	/// labeled alternative in <see cref="NBMothParser.parse_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMachineParseUnit([NotNull] NBMothParser.MachineParseUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PredicateClause</c>
	/// labeled alternative in <see cref="NBMothParser.machine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredicateClause([NotNull] NBMothParser.PredicateClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DeclarationClause</c>
	/// labeled alternative in <see cref="NBMothParser.machine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclarationClause([NotNull] NBMothParser.DeclarationClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>InitialisationClause</c>
	/// labeled alternative in <see cref="NBMothParser.machine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitialisationClause([NotNull] NBMothParser.InitialisationClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OperationsClause</c>
	/// labeled alternative in <see cref="NBMothParser.machine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperationsClause([NotNull] NBMothParser.OperationsClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SetsClause</c>
	/// labeled alternative in <see cref="NBMothParser.machine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetsClause([NotNull] NBMothParser.SetsClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DefinitionClauseIndirection</c>
	/// labeled alternative in <see cref="NBMothParser.machine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinitionClauseIndirection([NotNull] NBMothParser.DefinitionClauseIndirectionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DeferredSet</c>
	/// labeled alternative in <see cref="NBMothParser.set_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeferredSet([NotNull] NBMothParser.DeferredSetContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EnumeratedSet</c>
	/// labeled alternative in <see cref="NBMothParser.set_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumeratedSet([NotNull] NBMothParser.EnumeratedSetContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DefinitionClause</c>
	/// labeled alternative in <see cref="NBMothParser.definition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinitionClause([NotNull] NBMothParser.DefinitionClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OrdinaryDefinition</c>
	/// labeled alternative in <see cref="NBMothParser.single_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrdinaryDefinition([NotNull] NBMothParser.OrdinaryDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DefinitionFile</c>
	/// labeled alternative in <see cref="NBMothParser.single_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinitionFile([NotNull] NBMothParser.DefinitionFileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DefinitionAmbiguousCall</c>
	/// labeled alternative in <see cref="NBMothParser.definition_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinitionAmbiguousCall([NotNull] NBMothParser.DefinitionAmbiguousCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DefinitionExpression</c>
	/// labeled alternative in <see cref="NBMothParser.definition_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinitionExpression([NotNull] NBMothParser.DefinitionExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DefinitionPredicate</c>
	/// labeled alternative in <see cref="NBMothParser.definition_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinitionPredicate([NotNull] NBMothParser.DefinitionPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DefinitionSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.definition_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinitionSubstitution([NotNull] NBMothParser.DefinitionSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Operation</c>
	/// labeled alternative in <see cref="NBMothParser.single_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation([NotNull] NBMothParser.OperationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NBMothParser.quantified_variables_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuantified_variables_list([NotNull] NBMothParser.Quantified_variables_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NBMothParser.identifier_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier_list([NotNull] NBMothParser.Identifier_listContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SelectSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectSubstitution([NotNull] NBMothParser.SelectSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CaseSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseSubstitution([NotNull] NBMothParser.CaseSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConditionSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionSubstitution([NotNull] NBMothParser.ConditionSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BlockSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockSubstitution([NotNull] NBMothParser.BlockSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AnySubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnySubstitution([NotNull] NBMothParser.AnySubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParallelSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParallelSubstitution([NotNull] NBMothParser.ParallelSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfSubstitution([NotNull] NBMothParser.IfSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SkipSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSkipSubstitution([NotNull] NBMothParser.SkipSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BecomesElementOfSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBecomesElementOfSubstitution([NotNull] NBMothParser.BecomesElementOfSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>WhileSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileSubstitution([NotNull] NBMothParser.WhileSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AssignSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignSubstitution([NotNull] NBMothParser.AssignSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BecomesSuchThatSubstitution</c>
	/// labeled alternative in <see cref="NBMothParser.substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBecomesSuchThatSubstitution([NotNull] NBMothParser.BecomesSuchThatSubstitutionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NBMothParser.expression_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression_list([NotNull] NBMothParser.Expression_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NBMothParser.formula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormula([NotNull] NBMothParser.FormulaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PredicateIdentifier</c>
	/// labeled alternative in <see cref="NBMothParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredicateIdentifier([NotNull] NBMothParser.PredicateIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PredicateDefinitionCall</c>
	/// labeled alternative in <see cref="NBMothParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredicateDefinitionCall([NotNull] NBMothParser.PredicateDefinitionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>QuantifiedPredicate</c>
	/// labeled alternative in <see cref="NBMothParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuantifiedPredicate([NotNull] NBMothParser.QuantifiedPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PredicateOperator</c>
	/// labeled alternative in <see cref="NBMothParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredicateOperator([NotNull] NBMothParser.PredicateOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PredicateOperatorWithExprArgs</c>
	/// labeled alternative in <see cref="NBMothParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredicateOperatorWithExprArgs([NotNull] NBMothParser.PredicateOperatorWithExprArgsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesesPredicate</c>
	/// labeled alternative in <see cref="NBMothParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesesPredicate([NotNull] NBMothParser.ParenthesesPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SetComprehensionExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetComprehensionExpression([NotNull] NBMothParser.SetComprehensionExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SetEnumerationExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetEnumerationExpression([NotNull] NBMothParser.SetEnumerationExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>QuantifiedExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuantifiedExpression([NotNull] NBMothParser.QuantifiedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CastPredicateExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCastPredicateExpression([NotNull] NBMothParser.CastPredicateExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SequenceEnumerationExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSequenceEnumerationExpression([NotNull] NBMothParser.SequenceEnumerationExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NumberExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberExpression([NotNull] NBMothParser.NumberExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionCallExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallExpression([NotNull] NBMothParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] NBMothParser.IdentifierExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionOperator</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionOperator([NotNull] NBMothParser.ExpressionOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesesExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesesExpression([NotNull] NBMothParser.ParenthesesExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StringExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringExpression([NotNull] NBMothParser.StringExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EmptySetExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptySetExpression([NotNull] NBMothParser.EmptySetExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NestedCoupleAsTupleExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNestedCoupleAsTupleExpression([NotNull] NBMothParser.NestedCoupleAsTupleExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EmptySequenceExpression</c>
	/// labeled alternative in <see cref="NBMothParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptySequenceExpression([NotNull] NBMothParser.EmptySequenceExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NBMothParser.ltlStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLtlStart([NotNull] NBMothParser.LtlStartContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LTLParentheses</c>
	/// labeled alternative in <see cref="NBMothParser.ltlFormula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLTLParentheses([NotNull] NBMothParser.LTLParenthesesContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LTLBPredicate</c>
	/// labeled alternative in <see cref="NBMothParser.ltlFormula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLTLBPredicate([NotNull] NBMothParser.LTLBPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LTLPrefixOperator</c>
	/// labeled alternative in <see cref="NBMothParser.ltlFormula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLTLPrefixOperator([NotNull] NBMothParser.LTLPrefixOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LTLKeyword</c>
	/// labeled alternative in <see cref="NBMothParser.ltlFormula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLTLKeyword([NotNull] NBMothParser.LTLKeywordContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LTLInfixOperator</c>
	/// labeled alternative in <see cref="NBMothParser.ltlFormula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLTLInfixOperator([NotNull] NBMothParser.LTLInfixOperatorContext context);
}