using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public List<String> validationErrors { get; set; }

        public ValidationException(ValidationResult validationResult)
        { validationErrors = new List<String>();

            foreach (var item in validationResult.Errors)
            {
                validationErrors.Add(item.ErrorMessage);
            }
        
        
        }
    }
}
