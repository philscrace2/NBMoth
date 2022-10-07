using System;

namespace NBMoth.Parser{    

    public class ParserException : Exception
    {
    private static readonly long serialVersionUID = -1087348864429528237L;
    private readonly Exception exception;

    public ParserException(Exception e)
    {
        this.exception = e;
    }

    public Exception getException()
    {
        return this.exception;
    }

    public string getMessage()
    {
       return exception.Message;
    }
}

}
