Описание проекта

Данное консольное приложение предназначено для учета животных Московского зоопарка. Оно позволяет:

-Добавлять животных и проверять их здоровье перед приемом в зоопарк.
-Вести учет потребления корма.
-Определять животных, доступных для контактного зоопарка.
-Учитывать инвентарь с инвентарными номерами.
-Выводить отчет по количеству животных и потребляемому ими килограммов еды в день.
-Формировать списки животных, пригодных для контактного зоопарка.
-Позволять ветеринарной клинике принимать или отклонять животных на основании их здоровья.
-Обеспечивать интерактивное взаимодействие с пользователем через консольное меню.
-Приложение разработано с учетом принципов SOLID и использует Dependency Injection (DI) для управления зависимостями.

Применение принципов SOLID:

-Single Responsibility Principle (SRP): Каждый класс отвечает только за свою область (животные, инвентарь, ветеринарная клиника и т.д.).
-Open/Closed Principle (OCP): Добавление новых животных или предметов не требует изменения существующего кода, а только расширяет систему.
-Liskov Substitution Principle (LSP): Подтипы (наследники Animal) могут использоваться вместо базового класса без изменения логики.
-Interface Segregation Principle (ISP): Разделены интерфейсы IAlive и IInventory, чтобы классы реализовывали только необходимые им методы.
-Dependency Inversion Principle (DIP): Используется DI-контейнер (Microsoft.Extensions.DependencyInjection) для управления зависимостями, например, ветеринарная клиника внедряется в зоопарк.

Ожидаемый вывод

При запуске программы пользователю будет предложено консольное меню для выбора действий:

Выберите действие:
1. Добавить животное
2. Вывести отчет о потреблении корма
3. Вывести список контактных животных
4. Вывести инвентарные номера
5. Выход

Пользователь сможет вводить данные, программа будет динамически обновлять информацию в зоопарке.

Пример использования

Добавить животное:
Программа предложит ввести имя животного, количество потребляемой еды и уровень доброты.

Вывести отчет:
Программа выведет отчет по потреблению корма, доступных для контактного зоопарка животных и инвентарные номера.

Автор:
Бичурин Амир Маратович, БПИ234
