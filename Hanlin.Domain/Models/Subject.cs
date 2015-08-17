using Hanlin.Common.Enums;

namespace Hanlin.Domain.Models
{
    public static class StandardSubjectCode
    {
        public const string ��y = "ch";
        public const string ��� = "pc";
        public const string �^�y = "en";
        public const string �ƾ� = "ma";
        
        public const string �ͬ� = "li";
        public const string ���d�P��| = "pe";

        public const string �۵M = "na";
        public const string �ͪ� = "bi";
        public const string �z�� = "py";
        public const string �a�� = "ea";
        public const string ���z = "ph";
        public const string �ƾ� = "ce";

        public const string ���| = "so";
        public const string ���v = "hi";
        public const string �a�z = "ge";
        public const string ���� = "cs";
        public const string �����^�� = "he";//add 2015/7/9 by Kevin.
    }

    public class Subject : Enumeration<string>
    {
        public static readonly Subject ��y = new Subject(StandardSubjectCode.��y, "��y", "�y��", 100, new[] { Education.��p });
        public static readonly Subject ��� = new Subject(StandardSubjectCode.���, "���", "�y��", 110, new[] { Education.�ꤤ, Education.���� });
        public static readonly Subject �^�y = new Subject(StandardSubjectCode.�^�y, "�^�y", "�y��", 120, new[] { Education.�ꤤ, Education.���� });
        public static readonly Subject �ͬ� = new Subject(StandardSubjectCode.�ͬ�, "�ͬ�", "�ͬ�", 120, new[] { Education.��p });
        public static readonly Subject ���d�P��| = new Subject(StandardSubjectCode.���d�P��|, "���d�P��|", "���d�P��|", 120, new[] { Education.��p });

        public static readonly Subject �ƾ� = new Subject(StandardSubjectCode.�ƾ�, "�ƾ�", "�ƾ�", 230, new[] { Education.�ꤤ, Education.���� });

        public static readonly Subject �ͪ� = new Subject(StandardSubjectCode.�ͪ�, "�ͪ�", "�ۥ�", 340, new[] { Education.�ꤤ, Education.���� });
        public static readonly Subject �z�� = new Subject(StandardSubjectCode.�z��, "�z��", "�ۥ�", 350, new[] { Education.�ꤤ });
        public static readonly Subject �a�� = new Subject(StandardSubjectCode.�a��, "�a��", "�ۥ�", 360, new[] { Education.�ꤤ });
        public static readonly Subject ���z = new Subject(StandardSubjectCode.���z, "���z", "�ۥ�", 350, new[] { Education.���� });
        public static readonly Subject �ƾ� = new Subject(StandardSubjectCode.�ƾ�, "�ƾ�", "�ۥ�", 360, new[] { Education.���� });

        public static readonly Subject ���v = new Subject(StandardSubjectCode.���v, "���v", "���|", 470, new[] { Education.�ꤤ, Education.���� });
        public static readonly Subject �a�z = new Subject(StandardSubjectCode.�a�z, "�a�z", "���|", 480, new[] { Education.�ꤤ, Education.���� });
        public static readonly Subject ���� = new Subject(StandardSubjectCode.����, "����", "���|", 490, new[] { Education.�ꤤ, Education.���� });

        public static readonly Subject �����^�� = new Subject(StandardSubjectCode.�����^��, "�����^��", "�����^��", 500, new[] { Education.���� });//add 2015/7/9 by Kevin.
        /* ��� */
        public static readonly Subject �۵M�P�ͬ���� = new Subject(StandardSubjectCode.�۵M, "�۵M�P�ͬ����", "�ۥ�", 300, new Education[0]);
        public static readonly Subject ���| = new Subject(StandardSubjectCode.���|, "���|", "���|", 400, new Education[0]);


        public Subject()
        {
            
        }

        public Subject(string value, string name, string area, int order, Education[] educations)
            : base(value, name)
        {
            Area = area;
            Order = order;
            Educations = educations;
        }

        public string Area { get; private set; }
        public int Order { get; private set; }
        public Education[] Educations { get; private set; }
    }
}
