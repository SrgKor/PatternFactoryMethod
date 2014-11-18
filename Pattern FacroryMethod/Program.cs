using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_FacroryMethod
{
    // Класс задает возможность чтения данных с некоторого источника
    abstract class AbstractReader
    {
        public abstract void readData(Object input);
    }

    // Класс для считывания данных с БД
    class ReaderDataBase : AbstractReader
    {
        public override void readData(Object input)
        {
            // некоторый код реализации
        }
    }

    // Класс для считывания данных с текстового файла
    class ReaderTextFile : AbstractReader
    {
        public override void readData(Object input)
        {
            // некоторый код реализации
        }
    }

    // Класс для считывания двоичного кода
    class ReaderBinaryFile : AbstractReader
    {
        public override void readData(Object input)
        {
            // некоторый код реализации
        }
    }

    // Класс Фабричный метод для создания соответствующего объекта
    class FactoryMethod
    {
        AbstractReader getCurrentReader(Object input)
        {
            /*
            AbstractReader reader;
            
            if (input рассматривается как формат табличных данных)
            {
                someReader = new ReaderDataBase();
            }
            if (input рассматривается как текст)
            {
                someReader = new ReaderTextFile();
            }
            if (input рассматривается как двоичные данные)
            {
                someReader = new ReaderBinaryFile();
            }
             
            */
            return reader;
        }

    }
}

  