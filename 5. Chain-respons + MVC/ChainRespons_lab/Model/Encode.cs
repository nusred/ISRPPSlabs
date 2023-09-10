using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainRespons_lab.Model
{

    /// <summary>
    /// асбрактный класс событие
    /// </summary>
    abstract class Encoding
    {
        protected Encoding objectencode;

        /// <summary>
        /// связь объектов
        /// </summary>
        /// <param name="handleobject"></param>
        public void LinkToObject(Encoding handleobject)
        {
            this.objectencode = handleobject;
        }

        public abstract char Requre(char c);
    }

    /// <summary>
    /// кодирование цифр цифр
    /// </summary>
    class EncodingDigits : Encoding
    {
        public override char Requre(char c)
        {
            if (Char.IsDigit(c))
            {
                return (char)((int)c + 5);
            }
            return this.objectencode.Requre(c);
        }
    }

    /// <summary>
    /// кодирование в верхнем регистре
    /// </summary>
    class EncodingUpper: Encoding
    {
        public override char Requre(char c)
        {
            if (Char.IsUpper(c))
            {
                return (char)((int)c + 10);
            }
            else
            {
                return this.objectencode.Requre(c);
            }
        }
    }


    /// <summary>
    /// кодтрование в нижнем регистре
    /// </summary>
    class EncodingLower : Encoding
    {
        public override char Requre(char c)
        {
            if (Char.IsLower(c))
            {
                return (char)((int)c + 10);
            }
            else
            {
                throw new ArgumentException("символ явлется недопустимым");
            }
        }
    }
}

