using Hanlin.Common.Enums;

namespace Hanlin.Common.Models
{
    public class Education : Enumeration<string>
    {
        public static readonly Education ��p = new Education("primary", "��p");
        public static readonly Education �ꤤ = new Education("junior", "�ꤤ");
        public static readonly Education ���� = new Education("senior", "����");
        public static readonly Education ��¾ = new Education("vocational", "��¾");
        public static readonly Education ���� = new Education("preschool", "����");

        public Education()
        {
        }

        public Education(string value, string name) : base(value, name)
        {
        }

    }
}