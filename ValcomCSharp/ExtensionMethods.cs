﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valcom.Enums;

namespace Valcom
{

    public static class ExtensionMethods
    {

        #region Strings 

        /// <summary>
        /// Remover todos os espaços espaços em branco na string.
        /// </summary>
        /// <param name="value">String para remover os espaços em branco.</param>
        /// <returns></returns>
        public static string RemoveWhiteSpace(this string value)
        {
            value = value.Trim();
            value = value.Replace(" ", "");
            return value;
        }

        /// <summary>
        /// Remover todas as caracteres especiais na string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RemoveSpecialCharacters(this string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in value) { if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_') { sb.Append(c); } }
            return sb.ToString();
        }

        /// <summary>
        /// Primeira letra em maiuscula.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="eachWord">True = Todas as palavras na string / False = Somente a primeira palavra.</param>
        /// <returns></returns>
        public static string FirstCapitalLetter(this string value, bool eachWord = false)
        {
            string[] splited = value.Split(' ');
            value = string.Empty;
            for (int i = 0; i < splited.Length; i++)
            {
                if (!eachWord && i != 0) { continue; }
                var word = splited[i];
                word = word.Substring(0, 1); // Primeira letra.
                word = word.ToUpper();
                word += word.Substring(1, word.Length - 1);
                value += word;
            }
            return value;
        }

     
        #endregion
               

    }

}
