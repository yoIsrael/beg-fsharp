// Signature file for parser generated by fsyacc
#light
type token = 
  | LPAREN
  | RPAREN
  | EOF
  | MULTI
  | DIV
  | PLUS
  | MINUS
  | FLOAT of (System.Double)
  | ID of (string)
type tokenId = 
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_EOF
    | TOKEN_MULTI
    | TOKEN_DIV
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_FLOAT
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startExpression
    | NONTERM_Expression
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Expression : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Strangelights.ExpressionParser.Ast.Expr ) 
