using System.Collections.Generic;

namespace PrismWPF.Constants
{
    public class DBResultColumns
    {
        public static readonly List<string> ResultColumns = new() { "Фамилия", "Имя", "Отчество", "Дата рождения", "Телефон", "E-почта", "Отдел", "Должность" };
        public static readonly List<string> Departments = new() { "", "Финансовое управление", "Отдел снабжения", "Управление главного конструктора", "Отдел экономической безопасности" };
        public static readonly List<string> Positions = new() { "", "начальник", "зам.начальника", "ведущий экономист", "ведущий инженер", "инженер-конструктор", "снабженец" };

    }
}
