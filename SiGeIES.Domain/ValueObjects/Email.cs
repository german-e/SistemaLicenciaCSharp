using SiGeIES.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SiGeIES.Domain.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        private readonly string _valor;
        public Email(string valor) 
        { 
            if ( !IsEmailValid(valor) )
            {
                throw new ArgumentException($"El mail ingresado { valor }, no tiene un formato válido.");
            }

            _valor = valor;
        }

        public string Valor => _valor;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _valor;
        }

        private bool IsEmailValid(string email)
        {
            string regexPattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            var isMailValid = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);



            return isMailValid;


        }
    }
}
