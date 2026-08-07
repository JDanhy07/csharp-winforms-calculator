# 🧮 Calculadora — Windows Forms C#

Aplicación de calculadora de escritorio desarrollada en **C# con Windows Forms (.NET Framework)**, con diseño oscuro moderno, operaciones matemáticas avanzadas y panel de historial de operaciones.

---

## 📸 Vista general

> Calculadora con panel lateral de historial, tema oscuro y botones organizados por categoría.

---

## ✨ Funcionalidades

### Operaciones básicas
- Suma (`+`), Resta (`−`), Multiplicación (`*`), División (`÷`)
- Encadenamiento de operaciones sin perder el contexto (`3 + 5 × 2` se evalúa correctamente)

### Operaciones avanzadas
| Botón | Función |
|-------|---------|
| `√x`  | Raíz cuadrada |
| `x²`  | Elevar al cuadrado |
| `1/x` | Inverso multiplicativo |
| `%`   | Porcentaje |
| `+/−` | Cambio de signo |
| `.`   | Punto decimal |

### Panel de historial
- Registra hasta **50 operaciones** automáticamente
- Muestra la expresión completa y su resultado (`12 + 8 = 20`)
- **Doble clic** sobre cualquier entrada para recuperar ese resultado en la pantalla
- Botón **Limpiar** para borrar el historial

### Diseño
- Tema oscuro con colores por categoría de botón
  - 🔴 Rojo → AC (reset)
  - 🟢 Verde → Funciones avanzadas
  - 🔵 Azul → Operadores básicos
  - 🟣 Violeta → Igual (`=`)
- Display con línea de expresión activa (`12 +`) y resultado principal
- Manejo de errores discreto (sin `MessageBox`): los mensajes aparecen directamente en pantalla

---

## 🗂️ Estructura del proyecto

```
Calculadora/
├── Form1.cs               # Lógica de la calculadora (eventos, operaciones, historial)
├── Form1.Designer.cs      # Definición visual de controles y layout
├── Program.cs             # Punto de entrada de la aplicación
└── Calculadora.csproj     # Archivo de proyecto
```

---

## 🚀 Cómo ejecutar

### Requisitos
- Windows 10 / 11
- [Visual Studio 2019 o superior](https://visualstudio.microsoft.com/) con el componente **Desarrollo de escritorio con .NET**
- .NET Framework 4.7.2 o superior

### Pasos

1. Clona el repositorio:
   ```bash
   git clone https://github.com/jdanhy07/calculadora.git
   ```

2. Abre la solución en Visual Studio:
   ```
   Archivo → Abrir → Proyecto/Solución → Calculadora.sln
   ```

3. Compila y ejecuta con `F5` o el botón **▶ Iniciar**.

---

## 🛠️ Tecnologías utilizadas

| Tecnología | Versión |
|---|---|
| C# | 7.3+ |
| .NET Framework | 4.7.2+ |
| Windows Forms | Integrado |
| Visual Studio | 2019 / 2022 |

---

## 📋 Historial de cambios

### v2.0.0
- Nuevo diseño oscuro con colores por categoría
- Agregadas operaciones: raíz cuadrada, cuadrado, inverso, porcentaje, cambio de signo y punto decimal
- Panel lateral de historial con recuperación de resultados
- Cambio de `int` a `double` para soportar decimales
- Encadenamiento de operaciones
- Manejo de errores sin interrupciones (`MessageBox` eliminado)
- Label de expresión activa en el display

### v1.0.0
- Calculadora básica con suma, resta, multiplicación y división
- Botones del 0 al 9
- Reset (AC)

---

## 🤝 Contribuciones

Las contribuciones son bienvenidas. Para cambios importantes, abre primero un *issue* describiendo lo que deseas modificar.

1. Haz un fork del repositorio
2. Crea una rama: `git checkout -b feature/nueva-funcionalidad`
3. Realiza tus cambios y haz commit: `git commit -m "Agrega nueva funcionalidad"`
4. Sube la rama: `git push origin feature/nueva-funcionalidad`
5. Abre un Pull Request

