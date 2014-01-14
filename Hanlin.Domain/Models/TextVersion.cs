using Hanlin.Common.Enums;

namespace Hanlin.Domain.Models
{
    public class TextVersion : Enumeration<string>
    {
        public static readonly TextVersion ���L = new TextVersion("h", "���L");
        public static readonly TextVersion �d�a = new TextVersion("k", "�d�a");
        public static readonly TextVersion �n�@ = new TextVersion("n", "�n�@");
        public static readonly TextVersion ���s = new TextVersion("e", "���s");
        public static readonly TextVersion �q�� = new TextVersion("g", "�q��");

        public TextVersion()
        {
        }

        public TextVersion(string value, string name)
            : base(value, name)
        {
        }
    }
}
