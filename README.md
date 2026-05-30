# Custom 4-Bit Retro Microprocessor Emulator & Assembler

A custom software-simulated 4-Bit Microprocessor Architecture built in C# (WinForms) to emulate early-generation computer hardware behavior. This project bridges high-level software controls with strict hardware logic constraints, featuring a stack-based ALU, discrete registers, and a custom Assembler.

## Project Overview

This emulator simulates a complete 4-bit hardware execution cycle (Fetch, Decode, Execute) running over a shared 4-bit data bus. It includes an integrated Assembler that parses human-readable assembly mnemonics, encodes them into 8-bit machine words (4-bit opcode + 4-bit data/padding), loads them into program memory, and executes them through simulated logic gates.

### Key Features

- **Hardware Registers:** Two 4-bit general-purpose data registers (`AX` and `BX`).
- **Memory Stack:** A strict First-In, Last-Out (FILO/LIFO) sequential hardware stack acting as the primary data highway for ALU operations.
- **Arithmetic Logic Unit (ALU):** A combinational logic core performing bitwise operations (`AND`, `OR`, `XOR`, `NOT`), shift operations (`SHL`, `SHR`), and arithmetic operations (`ADD`, `SUB`, `INC`, `DEC`).
- **Dual Execution Modes:** Fully supports both **Single-Step** hardware debugging (line-by-line tracing) and **Batch Processing** (top-to-bottom execution).
- **UI Synchronization:** Real-time visual updating of binary state boxes, stack lists, and memory grids inside the WinForms interface.

---

## Hardware Execution Rules

- **AluBuffer:** Immediately before any operation runs, the ALU pops two values from the stack. The first popped value lands in TempB, and the second value lands in TempA.
- **Unary Operations:** For operations requiring only one operand (e.g., SHL, SHR, INC), the processor still forces the ALU to pop 2 values due to the shared hardware architecture. A dummy value must be pushed second to satisfy the TempB latch while the target data sits in TempA.
- **Bus Isolation:** All internal buffers are automatically flushed via ClearBuffers() at the end of every successful execution cycle to prevent residual data leakage into the next clock pulse.

## Project Structure & Documentation

All deep technical documentation and hardware specifications are organized within the dedicated documentation folder:

- **`documents/`**
  - `4-Bit Custom CPU Datasheet`: Contains full hardware component maps, schematic definitions, and execution cycle phase descriptions.
  - `Custom 4-Bit Microprocessor - ISA Reference Manual`: Detailed reference manual detailing every supported mnemonic, binary opcode mapping, and exact buffer routing logic.

---

## Sample Assembly Program

The following sample program demonstrates loading immediate data into registers, utilizing the hardware stack, and executing arithmetic operations via the ALU:

```assembly
PUSH AX, 0111  ; Load binary 0111 (Decimal 7) into AX and push to stack
PUSH BX, 0010  ; Load binary 0010 (Decimal 2) into BX and push to stack
SUB            ; Pops 0010 (TempB) and 0111 (TempA) -> Executes 7 - 2 = 5 (0101)
PUSH AX, 0110  ; Load binary 0110 (Decimal 6) into AX and push to stack
PUSH BX, 0011  ; Load binary 0011 (Decimal 3) into BX and push to stack
ADD            ; Pops 0011 (TempB) and 0110 (TempA) -> Executes 6 + 3 = 9 (1001)

```
### Screenshots 
![Screenshot 1](documents/schema1.png)
![Screenshot 2](documents/schema2.png)
![Screenshot 3](documents/programsc.png)

