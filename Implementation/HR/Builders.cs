using System;
using Practice.Common;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Класс-фабрика, позволяющий получать экземпляры типов,
    ///     инкапсулированных на уровне библиотеки.
    /// </summary>
    public static class Builders
    {
        /// <summary>
        ///     Возвращает экземпляр "Строителя" клиентов.
        /// </summary>
        /// <returns>
        ///     Экземпляр типа IClientBuilder.
        /// </returns>
        /// 

        private static IClientBuilder clientBuilder;

        public static IClientBuilder ClientBuilder()
        {
            /*
             * TODO #6: Реализовать фабричный метод ClientBuilder класса Builders
             */
            
            if (clientBuilder == null)
            {
                clientBuilder = new ClientBuilder();
            }

            return clientBuilder;
        }

        /// <summary>
        ///     Возвращает экземпляр "Строителя" сотудников.
        /// </summary>
        /// <returns>
        ///     Возвращает экземпляр типа IEmployeeBuilder.
        /// </returns>
        public static IEmployeeBuilder EmployeeBuilder()
        {
            /*
             * TODO #7: Реализовать фабричный метод EmployeeBuilder класса Builders
             */
            throw new NotImplementedException();
        }

        internal class ClientBuilder: IClientBuilder
        {
            private IClient client = new Client();

            public IClient Build ()
            {
                return client;
            }

            public IClientBuilder Discount (float discount)
            {
                client.Discount = discount;
                return this;
            }

            public IClientBuilder Name (IName name)
            {
                client.Name = new Name(name);
                return this;
            }

            public IClientBuilder Name (string name, string surname, string patronymic)
            {
                client.Name = new Name(name, surname, patronymic);
                return this;
            }
        }

        internal class EmployeeBuilder : IEmployeeBuilder
        {
            private Employee employee = new Employee();

            public IEmployee Build()
            {
                return employee;
            }

            public IEmployeeBuilder Department(IDepartment department)
            {
                employee.Department = department;
                return this;
            }

            public IEmployeeBuilder Department(string department)
            {
                employee.Department = new Department();
                return this;
            }

            public IEmployeeBuilder Name(IName name)
            {
                employee.Name = new Name(name);
                return this;
            }

            public IEmployeeBuilder Name(string name, string surname, string patronymic)
            {
                employee.Name = new Name(name, surname, patronymic);
                return this;
            }
        }

    }
}
