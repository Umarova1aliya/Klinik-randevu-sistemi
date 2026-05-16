# Klinik Randevu Sistemi 🏥

Bu layihə **C#** istifadə edilərək hazırlanmış çox sadə, ancaq tam işlək bir Klinika Randevu Sistemidir. 

Heç bir baza (SQL) qoşmağa ehtiyac yoxdur. Bütün kod cəmi **iki faylda** toplanıb və işləyən kimi ekranda cədvəlləri (DataGridView) olan hazır proqram pəncərəsi açılır.

## 💻 Bu Kodu Öz Kompüterində Necə İşlədə Bilərsən?

Bu kodu kopyalayaraq işlətmək cəmi 2 dəqiqəni alacaq. Heç bir xəta almamaq üçün sadəcə aşağıdakı addımları diqqətlə izlə:

### Addım 1: Yeni Layihə Yarat
1. Kompüterində **Visual Studio** proqramını aç.
2. **"Create a new project"** (Yeni layihə yarat) seçiminə kliklə.
3. Axtarış yerinə "Windows Forms" yaz və siyahıdan **"Windows Forms App"** (Console yox) seçib **Next** et.
4. Layihənin adını öz istədiyin kimi qoy (Məsələn: `KlinikSistem`) və **Create** düyməsinə basıb layihəni yarat.

### Addım 2: `Program.cs` Faylını Düzəlt
1. Layihə açılandan sonra sağ tərəfdəki siyahıdan (Solution Explorer) **`Program.cs`** faylına iki dəfə klikləyib aç.
2. İçindəki **hər şeyi tamamilə sil**.
3. Bu GitHub səhifəsindəki `Program.cs` faylının içindəki kodu kopyala və ora yapışdır.
4. **ÇOX VACİB:** Kodu yapışdırdıqdan sonra, kodun içindəki `namespace SƏNİN_LAYİHƏNİN_ADI` hissəsini öz layihənin adına uyğun dəyişdir. (Məsələn, layihənin adını KlinikSistem qoymusansa, `namespace KlinikSistem` olmalıdır).

### Addım 3: `Form1.cs` Faylını Düzəlt
1. İndi yenə sağ tərəfdəki siyahıdan **`Form1.cs`** faylına iki dəfə klikləyib aç.
2. İçindəki **hər şeyi tamamilə sil**.
3. Bu GitHub səhifəsindəki `Form1.cs` faylının içindəki kodu kopyala və ora yapışdır. (Kodun ən yuxarısında `#nullable disable` olmalıdır, o xətaların qarşısını alır).
4. **ÇOX VACİB:** Yenə də kodu yapışdırdıqdan sonra `namespace` adını yuxarıda etdiyin kimi öz layihənin adı ilə eyni etməyi unutma.

### Addım 4: Proqramı İşə Sal!
Hər şey hazırdır! İndi sadəcə Visual Studio-nun yuxarısındakı yaşıl **Start (F5)** düyməsinə bas. 

Qarşında Pasiyentlər, Həkimlər və Randevular cədvəli olan tam işlək bir proqram açılacaq. Proqramı yoxlamaq üçün içində hazır "Dr. Kamran Əliyev" və pasiyent "Aysel" məlumatları var. Əlavə edib silərək yoxlaya bilərsən! Uğurlar! 🚀
