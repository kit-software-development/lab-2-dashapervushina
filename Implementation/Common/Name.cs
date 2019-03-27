namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }

        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }

        public string FullName { get; }

        public string ShortName { get; }

        public Name(string surname, string firstname, string patronymic)
        {
            Surname = surname;
            FirstName = firstname;
            Patronymic = patronymic;
            FullName = surname + ' ' + firstname + ' ' + patronymic;
            ShortName = surname + ' ' + firstname[0] + ". " + patronymic[0] + '.';
        }

        public Name(IName name)
        {
            FullName = name.FullName;
            ShortName = name.ShortName;
            var arr = FullName.Split(' ');
            Surname = arr[0];
            FirstName = arr[1];
            Patronymic = arr[2];
        }
    }
}
