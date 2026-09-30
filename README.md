Math Game (Unity 2D / WebGL)

A fast-paced 2D mental math game built with Unity and C#. Players solve procedurally generated arithmetic challenges under pressure, managing a lives system and competing for high scores. Designed with a modular, component-based architecture and optimized for browser deployment via WebGL.

Features
Procedural Question Generation: Dynamically generates arithmetic problems with randomized operands and balanced difficulty progression.

Dynamic Lives & Scoring System: Tracks streaks and score multipliers, with a visual heart-based health display.

Immediate Visual & Audio Feedback: Color-coded UI cues (green/red flash) and animations for correct and incorrect answers.

Game State Management: Centralized game loop handling countdown timers, state transitions (Start, Playing, Game Over), and instant scene restarts.

WebGL Optimized: Configured for cross-platform browser play (decompressed WebGL pipeline for universal itch.io and web compatibility).

Architecture & Code Structure
The project follows a clean separation of concerns:

GameManager.cs — Controls core game state, rounds, score tracking, player lives, and high-level game loops.

QuestionGenerator.cs — Handles procedural arithmetic generation, operation weighting, and deterministic answer validation.

UIManager.cs — Manages HUD elements, lives display, color feedback transitions, score animations, and the Game Over modal.

InputController.cs — Processes numeric input via on-screen buttons and keyboard bindings with rapid submission support.

Tech Stack
Engine: Unity (2D)

Language: C#

Target Platform: WebGL (itch.io ready) 

Getting Started
Prerequisites
Unity Hub & Unity Editor (2022 LTS or newer recommended)

WebGL Build Support module installed
