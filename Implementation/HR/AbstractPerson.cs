using System;
using Practice.Common;
using Practice.HR.Events;
namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson: IPerson
    {
        private IName iname;

        public IName Name
        {
            get => iname;

            set
            {
                NameChange?.Invoke(this, new ValueChangeEventArgs<IName>(iname));
                iname = value;
            }
        }
       

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;

        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */
    }
}
