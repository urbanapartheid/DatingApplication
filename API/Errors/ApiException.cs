﻿namespace API.Errors
{
    public class ApiException
    {
        #region Properties
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
        #endregion

        #region CTOR
        public ApiException(int statusCode, string message = null, string details = null)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        } 
        #endregion
    }
}
