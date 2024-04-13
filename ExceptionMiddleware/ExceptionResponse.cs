using System.Net;

namespace Patterns.ExceptionMiddleware;

public record ExceptionResponse(object Response, HttpStatusCode StatusCode);