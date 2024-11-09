การLogin & RegisterแบบEZ
ขั้นตอนในการใช้งาน
1. ติดตั้งเครื่องมือที่จําเป็น
Visual Studio 2022 หรือ Visual Studio Code
.NET 8 SDK
SQL Server (แนะนํา) - สามารถใช้ฐานข้อมูลอื่นได้ แต่ตรวจสอบให้แน่ใจว่ามีConnectionStringsที่ถูกต้อง
2. กําหนดConnectionStrings
ทําการเปลี่ยนแปลงConnectionStringsต่อในแฟ้มAppSettings.json
3. อัพเดตข้อมูล
ใช้ Visual Studio:
ไปที่ Tools => NuGet Package Manager => Package Manager Console
เรียกใช้คําสั่ง: .update-database
ใช้ Visual Studio Code:
เปิดเทอร์มินัล
เรียกใช้คําสั่งต่อไปนี้: .dotnet ef database update
