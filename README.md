# 🚀 Asteroids AR Project

An **Augmented Reality Asteroids game** built with **Unity 2021.3.1f1** and **AR Foundation**, deployed on Android. The classic arcade shooter is reimagined in AR — asteroids, UFOs, and projectiles appear overlaid on the real world through the device camera.

---

## 🎮 Gameplay Demo

<div align="center">
  <video src="YOUR_REAL_VIDEO_URL_HERE" controls width="400"></video>
</div>
https://github.com/user-attachments/assets/e1d9b503-add2-4b24-9af7-e0e479bcdf2f


---

## ✨ Key Features & Highlights

### Augmented Reality Integration
- Built on **AR Foundation 4.2.3** with **ARCore 4.2.3** (Android) and **ARKit 4.2.3** (iOS-ready)
- Game objects (asteroids, UFOs, bullets, planet) are anchored and rendered in real-world AR space via the device camera
- XR Management handles session lifecycle and device feature negotiation

### Game Mechanics
| Feature | Description |
|---|---|
| **Asteroid Spawning** | `SpawnColliderArea.cs` continuously spawns asteroids at random positions within a 3D bounding volume until Game Over |
| **Player Shooting** | Tap the screen (`Input.GetMouseButtonDown(0)`) to fire projectiles; configurable fire rate via `_fireRate` |
| **UFO Enemy** | State-machine AI (`Idle` → `Attacking`) with randomised trajectory vectors and cooldown timers; moves toward the player at configurable speed |
| **Health System** | Both the **player** and the **planet** have independent health bars (`Health.cs`), with damage events and zero-health callbacks |
| **Health Pickups** | `HealthItem.cs` provides collectible health restore items scattered in the scene |
| **Scoring** | `GameState` ScriptableObject tracks score globally; `UIController.cs` updates TextMeshPro HUD in real time |
| **Game Over** | Triggered when player or planet health reaches zero; final score screen displayed |
| **Speed Control** | `GameManager.cs` drives `Time.timeScale` from a `GameState` ScriptableObject for easy difficulty tuning |

### Architecture
- **ScriptableObject-driven state** (`GameState`) decouples game logic from UI and gameplay scripts — no direct cross-script references needed
- **UnityEvent callbacks** throughout (`OnShoot`, `OnReceiveDamage`, `OnZeroHealth`, `OnStartAttacking`, …) keep components loosely coupled and Inspector-configurable
- **Coroutine-based timing** used for spawn loops, fire-rate limiting, and UFO idle cooldowns

### Rendering & Audio
- **Universal Render Pipeline (URP) 12.1.6** for mobile-optimised rendering
- **TextMeshPro 3.0.6** for crisp UI text at any resolution
- **SFX Arcade Free** sound effects for shooting, explosions, and UFO presence (`AudioSfx` component)

---

## 🛠️ Tech Stack

| Tool / Package | Version |
|---|---|
| Unity Editor | 2021.3.1f1 LTS |
| AR Foundation | 4.2.3 |
| ARCore XR Plugin | 4.2.3 |
| ARKit XR Plugin | 4.2.3 |
| Universal RP (URP) | 12.1.6 |
| TextMeshPro | 3.0.6 |
| XR Management | 4.2.1 |
| Target Platform | Android (ARCore) |

---

## 📁 Project Structure

```
Assets/
├── Scripts/          # All C# gameplay scripts
│   ├── GameManager.cs          # Time scale & game state init
│   ├── Player.cs               # Touch-to-shoot input
│   ├── UFO.cs / UFOAttack.cs   # Enemy AI & attack logic
│   ├── SpawnColliderArea.cs    # Asteroid spawner
│   ├── Health.cs / HealthItem.cs  # Health system
│   ├── MoveForward.cs          # Projectile/asteroid movement
│   ├── MakeDamage.cs           # Collision damage applier
│   ├── DestroyObject/AfterTime # Cleanup helpers
│   ├── UIController.cs         # HUD updates
│   └── SetInitialRotationTowardsTarget.cs
├── ScriptableObjects/ # GameState asset (shared game data)
├── Prefabs/           # Asteroid, bullet, UFO, planet prefabs
├── Scenes/            # Main AR game scene
├── Settings/          # URP renderer & XR config
├── _ARAsteroids/      # 3D models, fonts, VFX, UI assets
└── SFX Arcade Free/   # Sound effects
```

---

## 🚀 Getting Started

### Prerequisites
- Unity **2021.3.1f1** (LTS)
- Android SDK & NDK (via Unity Hub)
- Android device with **ARCore support**

### Build & Run on Android
1. Clone the repository
2. Open the project in Unity 2021.3.1f1
3. Go to **File → Build Settings** → select **Android** → Switch Platform
4. Enable **ARCore** in **Project Settings → XR Plug-in Management → Android**
5. Connect your Android device (USB debugging on)
6. Click **Build and Run**

---

## 📄 Report

Full project design, implementation details, and evaluation are documented in [`Asteroids Game_Report.pdf`](Asteroids%20Game_Report.pdf).

---

## 👤 Author

**Behnoud Shafizadeh**  
GitHub: [@behnoudshafizadeh](https://github.com/behnoudshafizadeh)
