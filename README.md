# Investigation of Statistical Properties of Stream Encryption Algorithm Krip

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Language: C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)

This repository contains the software implementation and statistical analysis of the **Krip lightweight stream cipher**. This project was developed as part of a Bachelor's Thesis at the National Technical University of Ukraine "Igor Sikorsky Kyiv Polytechnic Institute."

## 📌 Project Overview

The main objective of this research is to evaluate the cryptographic quality of the output gamma produced by the Krip algorithm. The analysis is performed using a suite of statistical tests to determine if the algorithm can be considered a reliable pseudo-random number generator (PRNG).

> **Note:** The core research and code were completed in 2023 as part of my Bachelor's thesis. In 2026, the repository was restructured, documented, and updated for better maintainability and clarity.

### ⚡ Key Features:
  - Full implementation of the **Krip stream encryption algorithm**.
  - Custom-built testing framework for statistical analysis.
  - Implementation of **6 specialized statistical tests** based on the **NIST SP 800-22** methodology.
  - High-performance processing for long sequences of ciphertexts.

### 🛠 Tech Stack
  - **Language:** C#
  - **Framework:** .NET / Visual Studio
  - **Domain:** Lightweight Cryptography, Statistical Analysis, PRNG

## 📂 Repository Structure
```
├── docs/                       # Bachelor's Thesis (PDF)
│   └── Bachelor_Thesis_Krip_Analysis.pdf  # Full research text (in Ukrainian)
├── src/                        # Source code
│   ├── Krip.slnx               # Visual Studio Solution
│   └── Krip/                   # Project folder
│       ├── Algorithm.cs        # Core implementation of the Krip cipher
│       ├── Generator.cs        # Pseudo-random sequence generation logic
│       ├── Krip.csproj         # Project configuration
│       ├── LongOperation.cs    # Handling for extensive statistical calculations
│       ├── Program.cs          # Main entry point
│       └── Test.cs             # Statistical testing suite implementation
├── .gitignore                  # Standard .NET ignore rules
├── LICENSE
└── README.md
```

## 🧪 Statistical Testing
The output of the cipher was tested against the following criteria to ensure security:
  - **Chi-squared ($\chi^2$) Test** – Frequency analysis of bits.
  - **Longest Run of Ones** – Checking for abnormal clusters of identical bits.
  - **Bigram Test** – Frequency analysis of two-bit combinations.
  - **Runs Test** – Total number of runs of ones and zeros.
  - **Sign Change Test** – Analyzing the frequency of transitions between 0 and 1.
  - **Inversion Test** – Evaluating the linear complexity and order of the sequence.

**Result:** 95.6% of the generated sequences successfully passed all tests, confirming high-quality pseudo-random properties.

## 📊 Research Results

The statistical analysis proved that the **Krip algorithm** successfully passed all implemented NIST tests. The output gamma sequences showed no significant statistical deviations, confirming its effectiveness as a stream cipher for general-purpose encryption.

Detailed analysis, including p-values and statistical distribution charts, can be found in the full thesis document located in the `/docs` folder.

## 🚀 How to run

1. **Prerequisites**: Ensure you have [Visual Studio](https://visualstudio.microsoft.com/) (2022 or newer) installed with the **.NET desktop development** workload.
2. **Clone the repository**:
   ```bash
   git clone https://github.com/AnastasiaZAYU/investigation-of-statistical-properties.git
   ```
3. Open `src/Krip.slnx` in **Visual Studio**.
4. Build and run the project (F5).

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👩‍💻 Author

**Anastasiia Zatsarenko**
* **Bachelor of Applied Mathematics**
* Institute of Physics and Technology (IPT), Igor Sikorsky KPI, 2023.
