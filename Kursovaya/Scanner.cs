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
        private bool separator;

        public Scanner(string input)
        {
            this.input = RemoveSpaces(input);
            this.position = 0;
            this.separator = false;
        }

        public (int, string, string, int, int) GetNextToken()
        {
            if (position >= input.Length)
                return ((int)TokenType.End, "EOF", "Ошибка", position, position);

            int startPos = position;

            while (position < input.Length && char.IsWhiteSpace(input[position]))
            {
                position++;
            }

            if (position >= input.Length)
            {
                return ((int)TokenType.End, "EOF", "Ошибка", startPos + 1, position);
            }

            if (startPos < position && separator == true)
            {
                separator = false;
                return ((int)TokenType.Separator, "Разделитель", "(пробел)", startPos+1, position);
            }

            startPos = position;
            char current = input[position];

            if (MatchWord("Const", out int endPos))
            {
                if (endPos + 1 < input.Length && (char.IsLetterOrDigit(input[endPos + 1])))
                {
                    position = startPos; 
                }
                else
                {
                    separator = true;
                    return ((int)TokenType.KeywordConst, "Ключевое слово", "Const", startPos + 1, endPos + 1);
                }
            }

            if (MatchWord("string", out endPos))
            {
                if (endPos + 1 < input.Length && (char.IsLetterOrDigit(input[endPos + 1])))
                {
                    position = startPos;
                }
                else
                {
                    return ((int)TokenType.KeywordString, "Ключевое слово", "string", startPos + 1, endPos + 1);
                }
            }

            if ((current >= 'a' && current <= 'z') ||
                (current >= 'A' && current <= 'Z')
            )
            {
                StringBuilder identifier = new StringBuilder();
                while (position < input.Length &&
                    (
                        (input[position] >= 'a' && input[position] <= 'z') ||
                        (input[position] >= 'A' && input[position] <= 'Z') ||
                        (input[position] >= '0' && input[position] <= '9') ||
                        input[position] == '_'
                    )
                )
                {
                    identifier.Append(input[position]);
                    position++;
                }
                separator = false;
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
                strLiteral.Append("'");
                while (position < input.Length && input[position] != '\'')
                {
                    if (input[position] == ';')
                    {
                        return ((int)TokenType.Error, "Недопустимый символ", strLiteral.ToString(), startPos + 1, position);
                    }
                    strLiteral.Append(input[position]);
                    position++;
                }
                if (position < input.Length && input[position] == '\'')
                {
                    strLiteral.Append("'");
                    position++;
                }
                return ((int)TokenType.StringLiteral, "Строка", strLiteral.ToString(), startPos+1, position);
            }

            if (current == ';')
            {
                position++;
                return ((int)TokenType.EndStatement, "Конец оператора", ";", startPos+1, position);
            }
            
            if (!
                    (
                        (current >= 'a' && current <= 'z') ||
                        (current >= 'A' && current <= 'Z') ||
                        current == ':' ||
                        current == ';' ||
                        current == '\'' ||
                        current == '='
                    ) 
                )
            {
                StringBuilder errorLiteral = new StringBuilder();
                while (position < input.Length &&
                    (!
                        (
                            input[position] == ':' ||
                            input[position] == ';' ||
                            input[position] == '\'' ||
                            input[position] == '=' ||
                            char.IsWhiteSpace(input[position])
                        )
                    )
                )
                {
                    errorLiteral.Append(input[position]);
                    position++;
                }
                return ((int)TokenType.Error, "Недопустимый символ", errorLiteral.ToString(), startPos + 1, position);
            }
            position++;
            return ((int)TokenType.End, "EOF", "Ошибка", position, position);
        }

        public string RemoveSpaces(string input)
        {
            StringBuilder result = new StringBuilder();
            bool afterConst = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i).StartsWith("Const") && !afterConst)
                {
                    result.Append("Const");
                    i += 4;
                    afterConst = true;
                }
                else if (char.IsWhiteSpace(input[i]) && afterConst)
                {
                    result.Append(" ");
                    while (i + 1 < input.Length && char.IsWhiteSpace(input[i + 1]))
                        i++;
                    afterConst = false;
                }
                else if (!char.IsWhiteSpace(input[i]))
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
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
