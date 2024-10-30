# Plan budowy programu przewidującego ceny kryptowalut

## 1. Przygotowanie środowiska",

- Utwórz projekt C#.
- Dodaj bibliotekę Newtonsoft.Json do zarządzania danymi JSON.
- Skonfiguruj środowisko i zainstaluj wszelkie wymagane biblioteki.

## 2. Tworzenie klasy `CryptoPricePredictor`

- Utwórz klasę `CryptoPricePredictor`, która będzie odpowiadać za obliczenia regresji liniowej.
- Wprowadź pole `prices` jako listę `List<double>`, która będzie przechowywać historyczne ceny.
- Dodaj pole `daysCount`, które będzie reprezentować liczbę dni (ilość danych historycznych).

## 3. Dodanie metody `PredictNextPrice` do klasy `CryptoPricePredictor`

- W metodzie `PredictNextPrice` dodaj sprawdzenie, czy dane historyczne są dostępne (czy `daysCount` nie jest równe 0).
- Oblicz sumy `sumX`, `sumY`, `sumXY`, oraz `sumX2` dla danych historycznych.
- Dodaj obliczenia dla `slope` oraz `intercept`.
- Oblicz przewidywaną cenę na podstawie wartości `slope`, `intercept`, i `daysCount`.

## 4. Tworzenie klasy `Program` i metody `Main`

- W klasie `Program` dodaj metodę `Main` jako punkt wejściowy programu.
- Dodaj interfejs, aby użytkownik mógł podać nazwę kryptowaluty do przewidywania.

## 5. Implementacja metody `GetHistoricalPricesAsync` w klasie `Program`

- W klasie `Program` dodaj metodę `GetHistoricalPricesAsync` do pobierania danych historycznych z API CoinGecko.
- Zdefiniuj adres URL API, korzystając z wprowadzonej przez użytkownika nazwy kryptowaluty.
- Wyślij żądanie do API i przetwórz odpowiedź JSON, aby wyciągnąć ceny historyczne.
- Dodaj obsługę błędów, aby wychwycić ewentualne problemy podczas pobierania danych.

## 6. Integracja pobranych danych z `CryptoPricePredictor`

- W `Main` pobierz historyczne ceny i przekaz je do instancji `CryptoPricePredictor`.
- Uruchom metodę `PredictNextPrice` i wyświetl wynik przewidywanej ceny.
