using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Категория 1", "Забывать обуславливает повседневной отметить занимаемых воздействия образом мира работы гражданского.", "https://placehold.co/200", "Невероятный Хлопковый Портмоне", 197.33000000000001, "Популярный" },
                    { 2, "Категория 2", "Таким рост последовательного.", "https://placehold.co/200", "Эргономичный Меховой Кошелек", 81.719999999999999, "Рекомендуемый" },
                    { 3, "Категория 2", "В инновационный и от показывает дальнейших задач различных постоянное особенности.", "https://placehold.co/200", "Фантастический Бетонный Берет", 158.41999999999999, "Популярный" },
                    { 4, "Категория 1", "Рост широким идейные значение участниками играет.", "https://placehold.co/200", "Свободный Гранитный Плащ", 115.56999999999999, "Новинка" },
                    { 5, "Категория 1", "Массового высшего кадровой показывает.", "https://placehold.co/200", "Невероятный Гранитный Плащ", 852.90999999999997, "Новинка" },
                    { 6, "Категория 3", "Нашей обуславливает проверки разработке.", "https://placehold.co/200", "Великолепный Кожанный Ножницы", 831.41999999999996, "Новинка" },
                    { 7, "Категория 2", "Подготовке за что.", "https://placehold.co/200", "Практичный Хлопковый Клатч", 474.62, "Рекомендуемый" },
                    { 8, "Категория 2", "Нас предложений зависит системы существующий воздействия на путь очевидна.", "https://placehold.co/200", "Эргономичный Стальной Стул", 369.63, "Рекомендуемый" },
                    { 9, "Категория 3", "Разнообразный опыт а повседневной широким для модернизации кадров предложений.", "https://placehold.co/200", "Потрясающий Неодимовый Кошелек", 934.84000000000003, "Рекомендуемый" },
                    { 10, "Категория 2", "Ресурсосберегающих актуальность выполнять дальнейших начало.", "https://placehold.co/200", "Великолепный Стальной Кулон", 861.64999999999998, "Рекомендуемый" },
                    { 11, "Категория 2", "Инновационный постоянный систему направлений создаёт отметить административных курс очевидна ресурсосберегающих.", "https://placehold.co/200", "Большой Натуральный Куртка", 547.37, "Рекомендуемый" },
                    { 12, "Категория 1", "Воздействия развития укрепления сущности внедрения играет равным.", "https://placehold.co/200", "Интеллектуальный Натуральный Ремень", 331.50999999999999, "Новинка" },
                    { 13, "Категория 3", "Поэтапного прежде широкому.", "https://placehold.co/200", "Большой Неодимовый Автомобиль", 36.950000000000003, "Популярный" },
                    { 14, "Категория 2", "Материально-технической внедрения форм рост следует позиции прогрессивного модель правительством подготовке.", "https://placehold.co/200", "Невероятный Пластиковый Сабо", 138.68000000000001, "Популярный" },
                    { 15, "Категория 2", "Принимаемых кругу курс работы.", "https://placehold.co/200", "Грубый Гранитный Компьютер", 880.61000000000001, "Популярный" },
                    { 16, "Категория 1", "Начало создание нами структуры понимание системы дальнейших сложившаяся в национальный.", "https://placehold.co/200", "Потрясающий Хлопковый Носки", 850.22000000000003, "Новинка" },
                    { 17, "Категория 3", "Равным специалистов также актуальность.", "https://placehold.co/200", "Лоснящийся Пластиковый Ремень", 541.5, "Популярный" },
                    { 18, "Категория 1", "Представляет организации специалистов равным управление важную рост дальнейшее предпосылки.", "https://placehold.co/200", "Практичный Пластиковый Майка", 847.76999999999998, "Рекомендуемый" },
                    { 19, "Категория 1", "Консультация задания сознания организационной.", "https://placehold.co/200", "Практичный Деревянный Сабо", 178.22, "Популярный" },
                    { 20, "Категория 1", "Работы формированию следует системы активом.", "https://placehold.co/200", "Маленький Резиновый Автомобиль", 184.43000000000001, "Популярный" },
                    { 21, "Категория 1", "Технологий представляет нас новая.", "https://placehold.co/200", "Практичный Кожанный Кепка", 390.60000000000002, "Популярный" },
                    { 22, "Категория 2", "Проблем понимание таким повседневная внедрения модели.", "https://placehold.co/200", "Маленький Бетонный Кепка", 341.81, "Популярный" },
                    { 23, "Категория 1", "Намеченных материально-технической формированию значимость собой реализация изменений нами общественной структура.", "https://placehold.co/200", "Интеллектуальный Хлопковый Плащ", 919.73000000000002, "Популярный" },
                    { 24, "Категория 1", "Повышению сознания образом социально-ориентированный сущности ресурсосберегающих.", "https://placehold.co/200", "Большой Неодимовый Куртка", 746.48000000000002, "Новинка" },
                    { 25, "Категория 2", "Сложившаяся начало занимаемых правительством.", "https://placehold.co/200", "Потрясающий Неодимовый Автомобиль", 845.23000000000002, "Рекомендуемый" },
                    { 26, "Категория 3", "Задания сомнений сознания по материально-технической мира.", "https://placehold.co/200", "Грубый Натуральный Кулон", 942.23000000000002, "Популярный" },
                    { 27, "Категория 3", "Образом особенности отметить национальный интересный.", "https://placehold.co/200", "Практичный Резиновый Автомобиль", 941.11000000000001, "Популярный" },
                    { 28, "Категория 3", "И требует этих внедрения деятельности позволяет.", "https://placehold.co/200", "Потрясающий Стальной Куртка", 484.38, "Рекомендуемый" },
                    { 29, "Категория 3", "Значение новая рост задач модели зависит кадровой социально-экономическое определения всего.", "https://placehold.co/200", "Великолепный Натуральный Сабо", 308.85000000000002, "Новинка" },
                    { 30, "Категория 2", "Очевидна высокотехнологичная кадров настолько соображения актуальность играет рост постоянное представляет.", "https://placehold.co/200", "Интеллектуальный Гранитный Стул", 304.32999999999998, "Рекомендуемый" },
                    { 31, "Категория 2", "Стороны кадров участниками демократической с таким также что.", "https://placehold.co/200", "Лоснящийся Резиновый Компьютер", 524.62, "Новинка" },
                    { 32, "Категория 3", "Информационно-пропогандистское реализация степени влечёт подготовке административных требует укрепления.", "https://placehold.co/200", "Интеллектуальный Меховой Свитер", 688.86000000000001, "Новинка" },
                    { 33, "Категория 1", "Другой позволяет сфера играет дальнейших рост проверки с.", "https://placehold.co/200", "Грубый Стальной Плащ", 540.35000000000002, "Рекомендуемый" },
                    { 34, "Категория 3", "Постоянное прогресса работы задания разработке консультация.", "https://placehold.co/200", "Грубый Гранитный Берет", 424.73000000000002, "Популярный" },
                    { 35, "Категория 2", "Начало разработке активизации шагов.", "https://placehold.co/200", "Лоснящийся Деревянный Ножницы", 53.880000000000003, "Рекомендуемый" },
                    { 36, "Категория 1", "Проверки по интересный рамки массового широким настолько широким кадровой что.", "https://placehold.co/200", "Великолепный Резиновый Компьютер", 89.819999999999993, "Новинка" },
                    { 37, "Категория 3", "Определения что богатый систему забывать обеспечивает социально-ориентированный.", "https://placehold.co/200", "Свободный Бетонный Автомобиль", 187.78, "Рекомендуемый" },
                    { 38, "Категория 3", "Современного поставленных значение постоянный насущным материально-технической идейные эксперимент качества место.", "https://placehold.co/200", "Грубый Неодимовый Ремень", 97.180000000000007, "Популярный" },
                    { 39, "Категория 2", "Создаёт проект кадровой консультация национальный настолько интересный вызывает предпосылки.", "https://placehold.co/200", "Эргономичный Резиновый Автомобиль", 857.83000000000004, "Новинка" },
                    { 40, "Категория 2", "Инновационный интересный технологий.", "https://placehold.co/200", "Грубый Гранитный Портмоне", 468.06999999999999, "Рекомендуемый" },
                    { 41, "Категория 2", "Оценить работы подготовке информационно-пропогандистское уровня новая зависит.", "https://placehold.co/200", "Свободный Пластиковый Майка", 236.59, "Популярный" },
                    { 42, "Категория 1", "Эксперимент организации воздействия мира поэтапного кругу правительством.", "https://placehold.co/200", "Большой Бетонный Ботинок", 157.56999999999999, "Популярный" },
                    { 43, "Категория 2", "Сомнений соображения предпосылки инновационный.", "https://placehold.co/200", "Грубый Хлопковый Автомобиль", 236.09, "Рекомендуемый" },
                    { 44, "Категория 2", "Массового разработке формировании.", "https://placehold.co/200", "Интеллектуальный Гранитный Кулон", 133.5, "Новинка" },
                    { 45, "Категория 2", "Повышение анализа структура позиции рост.", "https://placehold.co/200", "Невероятный Гранитный Ножницы", 797.38999999999999, "Новинка" },
                    { 46, "Категория 1", "Инновационный базы важную инновационный различных нашей.", "https://placehold.co/200", "Интеллектуальный Пластиковый Стол", 542.71000000000004, "Рекомендуемый" },
                    { 47, "Категория 3", "Разнообразный ресурсосберегающих прежде сомнений богатый высшего обеспечение.", "https://placehold.co/200", "Интеллектуальный Меховой Кепка", 44.619999999999997, "Рекомендуемый" },
                    { 48, "Категория 2", "Повседневной сложившаяся обеспечение профессионального.", "https://placehold.co/200", "Большой Неодимовый Ботинок", 560.04999999999995, "Новинка" },
                    { 49, "Категория 2", "Также широким кадровой анализа.", "https://placehold.co/200", "Фантастический Меховой Портмоне", 572.32000000000005, "Рекомендуемый" },
                    { 50, "Категория 1", "Сущности структура зависит курс.", "https://placehold.co/200", "Лоснящийся Резиновый Клатч", 329.41000000000003, "Популярный" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
