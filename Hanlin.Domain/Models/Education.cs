using System.Collections.Generic;
using System.Linq;
using Hanlin.Common.Enums;

namespace Hanlin.Domain.Models
{
    public class Education : Enumeration<string>
    {
        public static readonly Education ��p = new Education("e", "��p");
        public static readonly Education �ꤤ = new Education("j", "�ꤤ");
        public static readonly Education ���� = new Education("h", "����");
        public static readonly Education ��¾ = new Education("v", "��¾");

        public Education()
        {
        }

        public Education(string value, string name) : base(value, name)
        {
        }

    }
}