# Access Modifiers

<https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers>

Caller's location | public | protected | internal protected | internal | private protected | private
| :------------------------------------- | :----- | :--- | :--- | :--- | :--- | :--- |
| Within the class                       | ✔️️ | ✔️ | ✔️ | ✔️ | ✔️ | ✔️ |
| Derived class (same assembly)          | ✔️   | ✔️ | ✔️ | ✔️ | ✔️ | ❌   |
| Non-derived class (same assembly)      | ✔️   | ✔️ | ❌   | ✔️ | ❌   | ❌   |
| Derived class (different assembly)     | ✔️   | ✔️ | ✔️ | ❌   | ❌   | ❌   |
| Non-derived class (different assembly) | ✔️   | ❌   | ❌   | ❌   | ❌   | ❌   |

<https://metanit.com/sharp/tutorial/3.2.php>

**private**: закрытый или приватный компонент класса или структуры. Приватный компонент доступен только в рамках своего класса или структуры.

**private protected**: компонент класса доступен из любого места в своем классе или в производных классах, которые определены в той же сборке.

**file**: добавлен в версии **C# 11** и применяется к типам, например, классам и структурам. Класс или структура с такми модификатором доступны только из текущего файла кода.

**protected**: такой компонент класса доступен из любого места в своем классе или в производных классах. При этом производные классы могут располагаться в других сборках.

**internal**: компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.

**protected internal**: совмещает функционал двух модификаторов protected и internal. Такой компонент класса доступен из любого места в текущей сборке и из производных классов, которые могут располагаться в других сборках.

**public**: публичный, общедоступный компонент класса или структуры. Такой компонент доступен из любого места в коде, а также из других программ и сборок.

---
