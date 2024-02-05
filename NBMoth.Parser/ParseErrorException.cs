using System.Text;

namespace NBMoth.Parser{

    //package de.bmoth.parser;

    //import org.antlr.v4.runtime.CommonToken;

    public class ParseErrorException : System.Exception
    {
        private static readonly long serialVersionUID = 2305560853973886094L;
        private readonly CommonToken token;

    public ParseErrorException(CommonToken token, string message) : base(message)
    {            
        this.token = token;
    }

        
        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Parse error: Unexpected input '").Append(token.getText()).append("' ");
            sb.Append("in line ").Append(token.getLine());
            sb.Append(" column " + token.getCharPositionInLine()).Append(".\n");
            sb.Append("Additional information: ").Append(base.Message);
            return sb.ToString();
        }
    }



}