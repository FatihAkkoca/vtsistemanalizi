Kullanıcı Adı:Fatih Şifre:1234 (Yanlış giriş yapıldığında uyarı veriyor.)

Kodlar ile yeni konut ekleme sağlandı raporda fotoğraflandı.

Kodlar ile konut silme sağlandı raporda fotoğraflandı.

Kodlar ile konut güncelleme sağlandı raporda fotoğraflandı.

Kodlar ile konut eklerken boşluk bırakıldığında uyar vermesi sağlandı.

Silme ve güncelleme işlemleri ad soyad parametresine göre sağlanıyor.

Filtreleme işlemleri semt, durum ve oda parametreleri ile checkbox aracılığıyla sağlanıyor.


GİRİŞ VE TANITIM
Teknolojinin hızla geliştiği günümüzde, birçok sektör dijital çözümlerle daha verimli ve düzenli bir yapıya kavuşmuştur. Bu dönüşümden etkilenen alanlardan biri de emlak yönetimi olmuştur. Özellikle apartman, site ve konut projelerinde artan konut sayısı, kira ve satış işlemlerinin çeşitlenmesi, bu süreçlerin geleneksel yöntemlerle yürütülmesini zorlaştırmaktadır. Kağıt üzerinde yapılan kayıtlar ya da dağınık dijital dosyalar, hem zaman kaybına neden olmakta hem de bilgi güvenliğini tehlikeye atmaktadır. Bu noktada devreye giren site içi emlak otomasyonu uygulaması, söz konusu sorunları ortadan kaldırmak ve emlak yönetimini dijitalleştirmek amacıyla geliştirilmiştir. Projemizin temel amacı, emlak bilgilerini düzenli ve merkezi bir sistem üzerinden takip edebilmek, işlemleri hızlandırmak ve kullanıcıların ihtiyaç duyduğu bilgilere kolay erişim sağlamaktır.
Geliştirilen bu uygulama, apartman veya site yönetimlerinin emlak portföylerini etkili bir şekilde yönetmelerine olanak tanır. Sistem üzerinden satılık ya da kiralık dairelerin semt, durum (kiralık/satılık), oda sayısı, metrekare ve fiyat gibi temel bilgileri kolaylıkla kayıt altına alınabilir, güncellenebilir veya silinebilir. Kullanıcılar, mevcut kayıtlar arasında filtreleme yaparak istedikleri kriterlere uygun konutlara kısa sürede ulaşabilirler. Uygulama ayrıca, kullanıcı arayüzü açısından sade ve anlaşılır bir yapıya sahiptir; bu sayede teknik bilgi seviyesi ne olursa olsun her kullanıcı rahatlıkla sistemi kullanabilir.Uygulama C# programlama dili kullanılarak geliştirilmiş olup, veri bağlantısı için ADO.NET altyapısı tercih edilmiştir. Veriler, güvenli bir şekilde SQL Server veritabanında saklanmakta ve ihtiyaç duyulan her an erişime açık tutulmaktadır. Gerektiğinde kullanıcı rolleri tanımlanarak sadece yetkili kişilerin kritik işlemler yapması sağlanabilir.Bu otomasyon sistemi sayesinde, site yönetimleri artık emlak işlemlerini hem daha hızlı hem de daha güvenli bir biçimde gerçekleştirebilmekte, manuel işlemlerden kaynaklanan hataların önüne geçilmektedir. Böylece zamandan tasarruf edilmekte, bilgiye ulaşım kolaylaşmakta ve genel olarak emlak yönetim süreci dijital bir düzene kavuşmaktadır. Proje, emlak sektöründe dijitalleşmenin ve otomasyonun ne denli önemli olduğunu gösteren somut bir örnek olma niteliğindedir.


SİSTEMİN ÇALIŞMA MANTIĞI
Site içi emlak otomasyonu sistemi, kullanıcıların emlak bilgilerini merkezi bir veritabanı aracılığıyla işlemesini sağlayan katmanlı bir yapı üzerine kuruludur. Uygulama, öncelikle kullanıcıdan alınan giriş verilerini (semt, oda sayısı, metrekare, fiyat, durum gibi) arayüz üzerinden toplar ve bu verileri ADO.NET bağlantı altyapısı kullanarak SQL Server veritabanına işler. Kullanıcı, sisteme yeni bir kayıt ekleyebilir, mevcut bir kaydı güncelleyebilir ya da silme işlemi gerçekleştirebilir. Ayrıca, sistemde yer alan filtreleme ve arama modülleri sayesinde kullanıcı, belirli kriterlere göre kayıtlı daireleri listeleyebilir. Örneğin; yalnızca 3+1 oda sayısına sahip ve semti Kuzeykent olan daireleri görüntüleyebilir. Her işlem, arka planda SQL sorguları aracılığıyla gerçekleştirilir ve sonuçlar kullanıcı arayüzüne geri yansıtılır. Tüm bu süreç, kullanıcı dostu bir arayüzle desteklenerek teknik bilgisi olmayan bireylerin bile sistemi rahatlıkla kullanabilmesine imkân tanır. Bu yapı sayesinde sistem, hem veri güvenliği hem de işlem hızı açısından yüksek verimlilik sağlar.

