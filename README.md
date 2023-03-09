# Тема: Конвертер валют (TODO: название)
## Функциональные требования
- Система должна содержать в себе список валют, который при необходимости можно пополнять, указывая полное название валюты, её аббревиатуру (три буквы, обычно, но не обязательно образуемые от её названия), страну-эмитента и обменный курс.
  - Обменный курс валюты содержит стоимость одной её единицы во всех других валютах, для которых курс предусмотрен.
  - Попытка обменять валюту на другую, для которой курс не указан, приводит к ошибке.
  - Обменный курс валют обновляется каждый день в виде пары "1 единица валюты1 : цена в единицах валюты2" для каждой пары валюта1-валюта2 и валюта2-валюта1. Необходимо, чтобы обменный курс для каждой конкретной валюты содержал в себе самые актуальные пары, в которых фигурирует эта валюта.
- В базу данных можно добавлять курс только на текущий или предыдущие дни. При этом при попытке добавить курс, уже внесенный в базу, приоритет отдается уже существующему.
- Необходимо предусмотреть возможность получить изменения курса валюты в процентах между определенными датами либо за последний месяц.
## Сущности
- Курс обмена (ExchangeRate). Определяется на конкретный день для конкретной пары валют. Содержит дату, для которой был актуален, ссылки на участвующие в нём валюты и цену их обмена друг на друга.
- Валюта (Currency). Имеет полное название, аббревиатуру (три буквы, обычно образуемые от названия), страну-эмитента и список всех обменных курсов, в которых она фигурирует.
