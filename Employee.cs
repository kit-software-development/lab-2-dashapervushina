using System;
using Practice.HR.Events;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         */
        private IDepartment idepartment;

        public IDepartment Department
        {
            get => idepartment;

            set
            {
                DepartmentChange?.Invoke(this, new ValueChangeEventArgs<IDepartment>(idepartment));
                idepartment = value;
            }
        }

        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;

    }
}
