# 🕹️ Swordman Game Project

## 👨‍💻 ผู้พัฒนา
- **นาย ธีรเดช ประสารสุข 673450195-4**

---

## 📖 รายละเอียดโปรเจค
โปรเจคนี้เป็นการพัฒนาเกมด้วย **Unity Engine (C#)**  
โดยมีวัตถุประสงค์เพื่อฝึกการสร้างเกมแอคชัน 2D ที่มีระบบอนิเมชัน การเคลื่อนไหว การต่อสู้ และระบบศัตรูพื้นฐาน

---

## 🎯 ฟีเจอร์หลัก

### 🧍 ตัวละครหลัก (Swordman)
- อนิเมชันหลักของตัวละคร:
  - 🧍 **Idle** – ยืนเฉย ๆ  
  - 🚶 **Walk Forward / Backward** – เดินหน้าและถอยหลัง  
  - 🦘 **Jump** – กระโดดขึ้น-ลง  
  - 💢 **Hurt** – เมื่อถูกโจมตี  
  - ☠️ **Dead** – เมื่อตาย  

- **ระบบพลังชีวิต (HP System)**
  - แสดงหลอดพลังชีวิต (Health Bar)
  - เมื่อถูกศัตรูโจมตี → HP ลดลง
  - เมื่อ HP = 0 → แสดงสถานะตาย (Dead) และแสดงข้อความ **Game Over**

---

### 👹 ระบบศัตรู (Enemy System) 🆕
เพิ่มศัตรูที่มีพฤติกรรมพื้นฐานดังนี้:

- 🚶 **Enemy Walk** – เดินเข้าหาผู้เล่นโดยอัตโนมัติ  
- ⚔️ **Attack Player** – เมื่อเข้าใกล้ผู้เล่นในระยะโจมตี จะทำให้ผู้เล่น **เสียพลังชีวิต**
- 💢 **สร้างความเสียหาย (Damage System)** – เมื่อศัตรูชนกับผู้เล่น จะเรียกฟังก์ชัน `TakeDamage()` ของผู้เล่น
- 🔄 **Flip Direction** – ศัตรูหันหน้าเข้าหาผู้เล่นอัตโนมัติ

---

## 📸 ภาพหน้าจอเกม

| สถานะ | ภาพหน้าจอ |
|-------|------------|
| ยืน (Idle) | <img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/1a939fe4-f1d1-4d65-a8a8-9c07461c2e0f" />|
| เดิน (Walk) |<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/49c324de-6a72-4183-8542-64a5e132edc9" />|
| กระโดด (Jump) |<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/1f400e34-3aed-44e7-b341-816f1efbba6c" />|
| บาดเจ็บ (Hurt + ลดเลือด) | <img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/c3815ec3-a00c-4887-8a92-27af7200a1c3" />|
| ตาย + Game Over | <img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/76da6d4e-02b5-4f5a-9fb5-b7b93f01067c" />|
| ทำให้ตัวละครได้รับความเสียหายจากศัตรู + ทำอนิเมชั่นการเดินของ Enemy + เมื่อตัวละครผู้เล่นได้รับความเสียหาย ให้ทำการลดเลือดและเล่นอนิเมชั่นของตัวละครผู้เล่น | <img width="1920" height="1080" alt="image" src="<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/37afe334-971f-4e0d-895a-4f6ebb34ae5b" />
" />|

