using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures
{
    /// <summary>
    /// Общий интерфейс урока
    /// </summary>
    public interface ILesson
    {
        string Name { get; }
        string Description { get; }
        void Demo();
    }
}
