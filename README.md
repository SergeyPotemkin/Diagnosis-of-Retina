# Diagnosis-of-Retina

Название проекта: 
Diagnosis of Retina – программный комплекс компьютерной диагностики сетчатки глаза.


Ссылка на сайт проекта: http://dor.winmon.ru

Помимо кастомного кода, размещенного на github, для работы необходимы:
  EntityFramework.ru.6.0.0(или выше)
  System.Data.SQLite.1.0.101.0
  System.Data.SQLite.Linq.1.0.101.0
  System.Data.SQLite.EF6.1.0.101.0 
  
Лицензия на исходный код, разработанного программного обеспечения: 
GNU General Public License v3.0
https://github.com/SergeyPotemkin/Diagnosis-of-Retina/blob/master/LICENSE


Краткое описание
Актуальность:
По данным Федерального агентства по здравоохранению каждый пятый россиянин страдает тем или иным расстройством зрения. Так, по результатам эпидемиологического мониторинга "показатели заболеваемости глаз в России неуклонно возрастают, и в большинстве регионов превышают среднеевропейские показатели в 1,5-2 раза".
Сейчас врачи все чаще применяют методики бесконтактной диагностики зрения, так на вооружении врачей-офтальмологов, имеется Оптический-когерентный томограф(ОКТ), который получает снимки сетчатки (обычно 19 снимков на один глаз). Для того, чтобы прочитать каждый снимок, уходит достаточное время и требуется высокий уровень классификации врача именно в чтении снимка. А ввиду того, что на данный момент нет никакой математической или статистической модели, врачу приходится полагаться лишь на собственный опыт при составлении заключения и отсутствует качественный способ обучить нового специалиста читать эти снимки.
Предлагаемое решение проблемы:
Разработка ПО, позволяющего обнаружить структурные изменения сетчатки глаза(патологии) на ранних стадиях. Создание инструмента, позволяющего накапливать и анализировать данные о этапах развития глазных патологий.

Описание технологии:
ПО прогоняет видеофайл снимков сетчатки через ряд разработанных мной алгоритмов (в которых заключается научная новизна проекта) и рассчитывает некоторые параметры. На снимке имеется определённое количество объектов, на которых имеется множество слабо различимых структурных изменений (если мы говорим о ранней стадии развития патологии), и разработанное ПО их обнаруживает, считает их количество, измеряет угловую изменчивость и зависимость, частотную составляющую и на основании этих данных формируются параметры.
ПО не вмешиваемся в процесс работы офтальмологов, оно помогаем им получить со снимков больше информации обращает его внимание на некоторые участки. Главная задача - дать врачу возможность работать не с абстрактным изображением, но и конкретными изображением, описанным числовыми параметрами. Кроме этого программное обеспечение позволяет накапливать и изучать информацию о развитии патологий и исследовать этапы их формирования; вести учет изменения структуры сетчатки пациентов; строить трехмерную модель сетчатки, выводить результаты диагностики на печать и т.д.
Преимущества перед конкурентами:
Сравнительная таблица представлена в тесте пояснительной записки. В результате анализа, были выявлены следующие основные конкурентные преимущества:
1.	Новые параметры оценки состояния сетчатки глаза;
2.	Возможность построения трехмерной модели исследуемых объектов;
3.	Возможность проводить сравнительный анализ параметров, изменяющихся с течением времени;
4.	Возможность работы с видеофайлами;
5.	Инструменты по экспорту данных, созданию отчетов в различных форматах

Результаты:
ПО внедрено на опытную эксплуатацию в клинику глазных болезней имени Разумовского. Получены положительные отзывы врачей-офтальмологов.
Ведутся переговоры по внедрению ПО в Саратовский государственный медицинский университет, с целью обучения специалистов офтальмологов и специалистов лучевой диагностики.
