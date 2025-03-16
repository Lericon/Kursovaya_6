using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    public class Scanner
    {
        private string input;
        private int position;

        public Scanner(string input)
        {
            this.input = input;
            this.position = 0;
        }

        public (int, string, string, int, int) GetNextToken()
        {
            if (position >= input.Length)
                return ((int)TokenType.Error, "EOF", "Ошибка", position, position);

            int startPos = position;
            char current = input[position];

            if (char.IsWhiteSpace(current))
            {
                position++;
                return ((int)TokenType.Separator, "Разделитель", "(пробел)", startPos+1, position);
            }

            if (MatchWord("Const", out int endPos))
                return ((int)TokenType.KeywordConst, "Ключевое слово", "Const", startPos+1, endPos+1);

            if (MatchWord("string", out endPos))
                return ((int)TokenType.KeywordString, "Ключевое слово", "string", startPos+1, endPos+1);

            if (char.IsLetter(current))
            {
                StringBuilder identifier = new StringBuilder();
                while (position < input.Length && char.IsLetterOrDigit(input[position]))
                {
                    identifier.Append(input[position]);
                    position++;
                }
                return ((int)TokenType.Identifier, "Идентификатор", identifier.ToString(), startPos+1, position);
            }

            if (current == ':')
            {
                position++;
                return ((int)TokenType.Symbol, "Символ", current.ToString(), startPos+1, position);
            }

            if (current == '=')
            {
                position++;
                return ((int)TokenType.AssignmentOperator, "Оператор присваивания", current.ToString(), startPos+1, position);
            }

            if (current == '\'')
            {
                position++;
                StringBuilder strLiteral = new StringBuilder();
                while (position < input.Length && input[position] != '\'')
                {
                    strLiteral.Append(input[position]);
                    position++;
                }
                if (position < input.Length && input[position] == '\'')
                    position++;
                return ((int)TokenType.StringLiteral, "Строка", strLiteral.ToString(), startPos+1, position);
            }

            if (current == ';')
            {
                position++;
                return ((int)TokenType.EndStatement, "Конец оператора", ";", startPos+1, position);
            }

            position++;
            return ((int)TokenType.Error, "Недопустимый символ: ", current.ToString(), startPos+1, position);
        }

        private bool MatchWord(string word, out int endPos)
        {
            if (input.Substring(position).StartsWith(word))
            {
                endPos = position + word.Length - 1;
                position += word.Length;
                return true;
            }
            endPos = position;
            return false;
        }
    }
}
