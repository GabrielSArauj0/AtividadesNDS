using FluentValidation.Results;
using MP.ApiDotNet6.Application.DTOs;

namespace MP.ApiDotNet6.Application.Services
{
    public class ResultService
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public ICollection<ErrorValidation> Errors { get; set; }
        
        public static ResultService RequestError(string message, ValidationResult validationResult)
        {
            return new ResultService
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrorValidation { Field = x.PropertyName, Message = x.ErrorMessage}).ToList()
            
            };
        }

        public static ResultService<T> RequestError<T>(string message, ValidationResult validationResult)
        {
            return new ResultService<T>
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrorValidation
                    { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()
            };
        }

        public static ResultService<T> Fail<T>(string message) => new ResultService<T> { IsSucess = false, Message = message };
        public static ResultService<T> Ok<T>(string message,T Data ) => new ResultService<T> { IsSucess = false, Message = message };
    }

    public class ResultService<T> : ResultService
    {
        public T Data { get; set; }
    }
}