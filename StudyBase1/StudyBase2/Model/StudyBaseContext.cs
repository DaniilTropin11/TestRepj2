using System;
using System.Data.Entity;
using System.Linq;

namespace StudyBase2.Model
{
    public class StudyBaseContext : DbContext
    {
        // Контекст настроен для использования строки подключения "StudyBaseContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "StudyBase2.Model.StudyBaseContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "StudyBaseContext" 
        // в файле конфигурации приложения.
        public StudyBaseContext()
            : base("name=StudyBaseContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}