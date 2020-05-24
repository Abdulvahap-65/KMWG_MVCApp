using DynamicsCRM.Entity;
using DynamicsCRM.Entity.Context;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dynamics_CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kurulum(BİLMEME GEREK YOK)
            CrmFactory _crmFactory;
            OrganizationServiceContext _context;
            XrmServiceContext _xrmContext = null;

            _crmFactory = CrmFactory.GetService();
            if (_crmFactory != null)
            {
                _context = _crmFactory.Context();
                _xrmContext = new XrmServiceContext(_crmFactory.OrganizationService);
            }
            #endregion

            #region -ŞAHİN HOCAMLA ÖRNEK ÇALIŞMA_uzm_portaluser-
      /* List<uzm_portaluser> user = _xrmContext.uzm_portaluserSet.ToList();
       int count = user.Count;*/
      //şimdi kayıtlara şu şekilde ulaşacağız.
      //parantezin içindeki kısım linq olarak geçiyor. online olunca bunu kullanıyorsun abi
      //bu şekilde de oluyormuş pardn
      //abi bu context i bir liste olarak düşün. biz bu listeye yeni eleman ekleyeceğiz
      //ama önce yeni kayıt oluşturalım. tipi de uzm_portaluser olacak demiştim.
      /* uzm_portaluser portaluser = new uzm_portaluser();*/
      //şimdi bu oluşturduğumuz değişkeni doldurmamız gerekiyor.
      /* portaluser.uzm_name = "Deneme Kullanıcı";
       portaluser.uzm_emailaddress = "denemekullanici@deneme.com";
       portaluser.uzm_username = "deneme.kullanici";
       portaluser.uzm_birthdate = DateTime.Now;
       portaluser.uzm_password = "1234";*/
      //kaydı oluşturduk ve içini doldurduk. şimdi de listeye eklememiz ve kaydetmemiz gerekiyor.
      /* _xrmContext.AddObject(portaluser); //veriyi listeye ekledik.
       var result = _xrmContext.SaveChanges();*///şimdi de kaydettik.
                                                //anladın mı abi? önceki yaptığın ödevler ile aynı:tamam.anladım efendiö:
                                                //:) ödevlerde de böyle yapıyordun değil mi veri kaydederken  evet
            #endregion
            #region -ÖDEVLERİM-
            #region -Ödev_1_uzm_city-
      //List<uzm_city> CityList = _xrmContext.uzm_citySet.ToList();
      //int count = CityList.Count;
      //uzm_city City = new uzm_city();
      //City.uzm_name = "İstanbul";
      //City.uzm_countryname = "denemekullanici@deneme.com";
      //City.uzm_platenumber = "34";
      //City.uzm_zipcode = "34000";
      //City.uzm_iscapital = false;
      //City.uzm_population = 16000000;
      //City.uzm_region = "Marmara";
      //_xrmContext.AddObject(City);
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_2_slck_country-
      //List<slck_country> CountryList = _xrmContext.slck_countrySet.ToList();
      //slck_country Country = new slck_country();
      //Country.slck_name = "U.S.A";
      //Country.slck_hemisphere = "Kuzey";
      //Country.slck_phonecode ="+91";
      //Country.slck_continent = "America";
      //_xrmContext.AddObject(Country);
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_3_abd1_city-
      //List<abd1_city> CityList = _xrmContext.abd1_citySet.ToList();
      //abd1_city City = new abd1_city();
      //City.abd1_name = "Van";
      //City.abd1_countryname = "Türkiye";
      //City.abd1_population = 1000300;
      //City.abd1_platenumber ="65";
      //City.abd1_zipcode = 65400;
      //City.abd1_iscapital =false;
      //_xrmContext.AddObject(City);
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_4_abd2_customer-
      //List<abd2_customer> CustomerList = _xrmContext.abd2_customerSet.ToList();
      //abd2_customer Customer = new abd2_customer();
      //Customer.abd2_name = "Mehmet";
      //Customer.abd2_surname = "SELÇUK";
      //Customer.abd2_birthdate = new DateTime(2000, 4, 10);
      //Customer.abd2_phone = "0567789043";
      //Customer.abd2_age = 8;
      //Customer.abd2_permission = true;
      //Customer.abd2_email = "mmtslcuk@gmail.com";
      //Customer.abd2_address = "Alfa mah. beta sokak. charlie bravo Zeytinburnu/İstanbul";
      //_xrmContext.AddObject(Customer);
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_5_abd3_customer-
      //List<abd3_customer> CustomerList1 = _xrmContext.abd3_customerSet.ToList();
      //abd3_customer Customer1 = new abd3_customer();
      //Customer1.abd3_trdentityno = "123455678";
      ////Customer.abd3_customerid =123;
      //Customer1.abd3_name = "A.Vahap";
      //Customer1.abd3_surname = "SELÇUK";
      //Customer1.abd3_DateofBirth = new DateTime(2000, 5, 10);
      //Customer1.abd3_placeofbirth = "ERCİŞ";
      //Customer1.abd3_age = 33;
      //Customer1.abd3_gender = "Erkek";
      //Customer1.abd3_maritalstatus = "Bekar";
      //Customer1.abd3_nationality = "TC";
      //Customer1.abd3_profession = "Engineer";
      //Customer1.abd3_phone = "0567789043";
      //Customer1.abd3_email = "abdslcuk@gmail.com";
      //Customer1.abd3_educationsituation = "Post grad.";
      //Customer1.abd3_currentsituation = "software eng.";
      //Customer1.abd3_address = "Alfa mah. beta sokak. charlie bravo Zeytinburnu/İstanbul";
      //Customer1.abd3_validuntil = new DateTime(2001, 4, 10);
            #endregion
            #region -Ödev_6_abd4_identity-

      //List<abd4_identitiy> IdentityList1 = _xrmContext.abd4_identitiySet.ToList();
      //abd4_identitiy Identity = new abd4_identitiy();
      //Identity.abd4_tridentityno = "12345509678";
      ////Customer.abd3_customerid =123;
      //Identity.abd4_surname = "YEN";
      //Identity.abd4_name = "Ali";
      //Identity.abd4_dateofbirth = new DateTime(2000, 8, 6);
      //Identity.abd4_documentno = "1359YTU";
      //Identity.abd4_validuntil = new DateTime(2030, 4, 10);
      //Identity.abd4_gender = "Male";//bunu hesaplasın
      //Identity.abd4_nationality = "TUR";
      //Identity.abd4_mothersname = "Arife";
      //Identity.abd4_fathersname = "Ahmet";
      //Identity.abd4_issuedby = "T.C İÇİŞLERİ BAKANLIĞI";
      //_xrmContext.AddObject(Identity);
      //var result = _xrmContext.SaveChanges();

            #endregion
            #region -Ödev_7_abd5_drivinglicence-
      //List<abd5_drivinglicence> LicenceList = _xrmContext.abd5_drivinglicenceSet.ToList();
      //abd5_drivinglicence Licence = new abd5_drivinglicence();
      //Licence.abd5_tridentityno = "12345509678";
      //Licence.abd5_surname = "HAMALİ";
      //Licence.abd5_name = "Kemal";
      //Licence.abd5_issuedatprovince_country = "IST./SILIVRI";
      //Licence.abd5_licencenumber= 12345667;
      //Licence.abd5_dateofissue = new DateTime(2013, 4, 6);
      //Licence.abd5_devicesandprosthesesused="Glasses";
      //Licence.abd5_province_county = "ISTANBUL/FLORYA";
      //Licence.abd5_neighborhood = "A.AY";
      //Licence.abd5_fathersname = "Ahmet";
      //Licence.abd5_mothersname = "Arife";
      //Licence.abd5_placeofbirth = "ISTANBUL";
      //Licence.abd5_dateofbirth = new DateTime(2000, 8, 6);
      //Licence.abd5_bloodgroup = "+BR";
      //Licence.abd5_signatureofcertificateholder = "vhp";
      //_xrmContext.AddObject(Licence);
      //var result = _xrmContext.SaveChanges();


            #endregion
            #region -Ödev_8_abd6_tinnumbercard-
      //List<abd6_tinnumbercard> CardList = _xrmContext.abd6_tinnumbercardSet.ToList();
      //abd6_tinnumbercard Card = new abd6_tinnumbercard();
      //Card.abd6_financialofficename = "VAN";
      //Card.abd6_taxoffice = "EGANİS";
      //// Card.abd6_tinnumbercardId = "12";
      //Card.abd6_taxpayeridentificationno = "456789011";
      //Card.abd6_surnametitle = "SELÇUK";
      //Card.abd6_name = "ABDULVAHAP";
      //Card.abd6_vehicleplateno = "P01";
      //Card.abd6_issuedby = "T.C MALİYE BAKANLIĞI";
      //_xrmContext.AddObject(Card);
      //var result = _xrmContext.SaveChanges();

            #endregion
            #region -Ödev_9_abd7_ytustudentidentitycard-
      //List<abd7_ytustudentidentitycard> CardList = _xrmContext.abd7_ytustudentidentitycardSet.ToList();
      //abd7_ytustudentidentitycard StCard = new abd7_ytustudentidentitycard();
      //StCard.abd7_name = "Kasım";
      //StCard.abd7_surname = "Süzen";
      //StCard.abd7_faculty = "Electric-electronic";
      //StCard.abd7_department = "Electrical Engineering";
      //StCard.abd7_dateofgraduation = new DateTime(2016, 07, 08);
      //StCard.abd7_nationaidno = 1234566;
      //StCard.abd7_studentno = "14";
      //_xrmContext.AddObject(StCard);
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_10_uzm_country-

      // List<uzm_country> CountryList = _xrmContext.uzm_countrySet.ToList();
      // uzm_country Country = new uzm_country();
      // Country.uzm_name = "France";
      // Country.uzm_hemisphere= "North";
      // Country.uzm_continent = "Europe";
      // Country.uzm_nationality="French";
      // Country.uzm_phonecode= "+33";
      //Country.uzm_population = 66990000;
      // _xrmContext.AddObject(Country);
      // var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_11_uzm_city-
      //List<uzm_city> CityList = _xrmContext.uzm_citySet.ToList();
      //uzm_city City = new uzm_city();
      //City.uzm_name = "Izmir";
      //City.uzm_countryname = "Turkey";
      //City.uzm_population = 4321000;
      //City.uzm_platenumber = "41";
      //City.uzm_zipcode ="16000";
      //City.uzm_iscapital = false;
      //_xrmContext.AddObject(City);
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_12_uzm_customer_OptionSet ve Lookup Yapma-
      ////CRM'de nationalities varlığından nationality name çekme
      //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.ToList();
      //uzm_nationality ulus = NationalityList.Where(i => i.uzm_name == "British").FirstOrDefault();
      //Guid ulusid = ulus.uzm_nationalityId.Value;
      ////CRM'de customers varlığına veri ekleme
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer Customer = new uzm_customer();
      //Console.WriteLine(ulusid);
      //Customer.uzm_nationalityid = new EntityReference("uzm_nationality", ulusid);//Xrm.Shemada  nationality lookup setleme
      //Customer.uzm_customernumber = "123rt456";
      //Customer.uzm_tridentityno = "15560978";
      //Customer.uzm_name = "Halit";//default mu bak
      //Customer.uzm_surname = "Ziya";
      //Customer.uzm_dateofbirth = new DateTime(1987, 5, 10);//Oğuzhana sor.Bugünün tarihinden yola çık.Doğum tarihini bul.
      //Customer.uzm_age = 33;
      //Customer.uzm_placeofbirth = "Bursa";
      //Customer.uzm_isgender = new OptionSetValue(1);//1-Erkek;2-Kadın;3-Diğer veririr.
      //Customer.uzm_ismaritalstatus = new OptionSetValue(1);//1-Bekar;2-Evli  verir.
      //Customer.uzm_iseducationstatus = new OptionSetValue(1);//1-Lise;2-Önlisans;3-Lisans;4-Lisansüstü;5-Doktora  verir.
      //Customer.uzm_profession = "Yazar";
      //Customer.uzm_iscurrentsituation = new OptionSetValue(1);//1-Çalışıyor;2-Çalışmıyor verir.
      //Customer.uzm_iscompanysector = new OptionSetValue(1);//Birşeyler yazdım ona bak verir.
      //Customer.uzm_ispermission = true;//two options
      //Customer.uzm_isdemandcategory = new OptionSetValue(1);//Birşeyler yazdım ona bak verir.
      //Customer.uzm_validuntil = new DateTime(2030, 4, 10);//date time çalış.
      //Customer.uzm_phone = "0567789043";
      //Customer.uzm_email = "halitzusakligil@gmail.com";
      //Customer.uzm_address = "alfa mah. beta sokak. charlie bravo zeytinburnu/istanbut" +
      //    "l";
      //_xrmContext.AddObject(Customer);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_13_uzm_country_LookupYapma-
      // List<uzm_country> CountryList = _xrmContext.uzm_countrySet.ToList();
      //  uzm_country Country = new uzm_country();
      //  Country.uzm_name = "America5";
      //  Country.uzm_hemisphere = "North";
      //  Country.uzm_continent = "Europe";
      //  Guid NationId = new Guid("{0AB31DCE-BF81-EA11-A811-000D3A249A17}");//???
      //Country.uzm_nationalityid = new EntityReference("uzm_country", NationId);
      ////  Country.uzm_nationality = "French";
      //  Country.uzm_phonecode = "+33";
      //  Country.uzm_population = 766990000;
      //  _xrmContext.AddObject(Country);
      //  var result = _xrmContext.SaveChanges();
      //  //uzm_portaluser portalUser = new uzm_portaluser();
      //  //portalUser.uzm_name = "Alex de Souza";
      //  //Guid istanbulId = new Guid("EB148EFB-1A78-EA11-9009-606DC7F721EA");
      //  //portalUser.uzm_cityid = new EntityReference("uzm_city", istanbulId);
      //  //_xrmContext.AddObject(portalUser);
      //  //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Ödev_14_uzm_customer ile uzm_nationalityid'yı[uzm_uzm_nationality_uzm_customer_nationalityid] Lookup Yapma,Option Setleme ve Kayıt Ekleme-
            #region -CRM'de nationalities varlığından nationality name çekme-
      //string wantedNationality;
      //Console.Write("ID'sine ulaşmak  istediğiniz müşterinin nationality bilgisini giriniz:");
      //wantedNationality = Console.ReadLine();
            #region -A.Tekli Veri Çekme-
            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //var nationalityOne = _xrmContext.uzm_nationalitySet.Where(i => i.uzm_name == wantedNationality).First(); 
            #endregion
            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-
      //var nationalityOne = (from I in _xrmContext.uzm_nationalitySet
      //                      where I.uzm_name == wantedNationality
      //                      select I).First();
            #endregion
      //Guid ulusid = nationalityOne.Id;
      //Console.WriteLine("İstemiş olduğunuz nationality bilgisinin name'i {0} ve ID'si  {1}'dir", nationalityOne.uzm_name, ulusid);
            #endregion
            #region -B.Çoklu Veri Çekme-

            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.ToList();
      //// uzm_nationality ulus = NationalityList.Where(i => i.uzm_name == wantedNationality).FirstOrDefault();
            #endregion

            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-
      //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.ToList();

      //uzm_nationality ulus = (from I in NationalityList
      //                        where I.uzm_name == wantedNationality
      //                        select I).FirstOrDefault();
            #endregion
      //Guid ulusid = ulus.uzm_nationalityId.Value;
      //Console.WriteLine("İstemiş olduğunuz nationality bilgisinin name'i {0} ve ID'si  {1}'dir", ulus.uzm_name, ulusid);

            #endregion

            #endregion
            #region -CRM'de customers varlığına veri ekleme-
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer Customer = new uzm_customer();
      //Customer.uzm_nationalityid = new EntityReference("uzm_nationality", ulusid);//Xrm.Shemada  nationality lookup setleme
      //Customer.uzm_customernumber = "123rt456";
      //Customer.uzm_tridentityno = "15560978";
      //Customer.uzm_name = "Cihat";//default mu bak
      //Customer.uzm_surname = "Çalım";
      //Customer.uzm_dateofbirth = new DateTime(1987, 5, 10);//Oğuzhana sor.Bugünün tarihinden yola çık.Doğum tarihini bul.
      //Customer.uzm_age = 33;
      //Customer.uzm_placeofbirth = "Istanbul";
      //Customer.uzm_isgender = new OptionSetValue(1);//1-Erkek;2-Kadın;3-Diğer veririr.
      //Customer.uzm_ismaritalstatus = new OptionSetValue(1);//1-Bekar;2-Evli  verir.
      //Customer.uzm_iseducationstatus = new OptionSetValue(1);//1-Lise;2-Önlisans;3-Lisans;4-Lisansüstü;5-Doktora  verir.
      //Customer.uzm_profession = "Yazar";
      //Customer.uzm_iscurrentsituation = new OptionSetValue(1);//1-Çalışıyor;2-Çalışmıyor verir.
      //Customer.uzm_iscompanysector = new OptionSetValue(1);//Birşeyler yazdım ona bak verir.
      //Customer.uzm_ispermission = true;//two options
      //Customer.uzm_isdemandcategory = new OptionSetValue(1);//Birşeyler yazdım ona bak verir.
      //Customer.uzm_validuntil = new DateTime(2030, 4, 10);//date time çalış.
      //Customer.uzm_phone = "0567789043";
      //Customer.uzm_email = "halitzusakligil@gmail.com";
      //Customer.uzm_address = "alfa mah. beta sokak. charlie bravo zeytinburnu/istanbul";
      //_xrmContext.AddObject(Customer);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
      //Console.WriteLine("Kayıt eklenmiştir.");
            #endregion
            #endregion
            #region -Ödev_15_uzm_customer ile uzm_workplacecityid'yi[uzm_uzm_workplacecity_uzm_customer_workplacecityid] Lookup Yapma,Option Setleme ve Kayıt Ekleme-
            #region -CRM'de workplacecities varlığından workplacecity name çekme-
      //string wantedNationality;
      //string wantedCity;
      //Console.Write("ID'sine ulaşmak  istediğiniz müşterinin nationality bilgisini giriniz:");
      //wantedNationality = Console.ReadLine();
      //Console.Write("\nMüşterinin ID'sine ulaşmak  istediğiniz şehrin workplacecity bilgisini giriniz:");
      //wantedCity = Console.ReadLine();
            #region -A.Tekli Veri Çekme-
            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //var nationalityOne = _xrmContext.uzm_nationalitySet.Where(i => i.uzm_name == wantedNationality).First();
      //var workplaceOne = _xrmContext.uzm_workplacecitySet.Where(i => i.uzm_name == wantedCity).FirstOrDefault();
            #endregion
            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-

      //var nationalityOne = (from I in _xrmContext.uzm_nationalitySet
      //                      where I.uzm_name == wantedNationality
      //                      select I).First();
      //var workplaceOne = (from I in _xrmContext.uzm_workplacecitySet
      //                    where I.uzm_name == wantedCity
      //                    select I).First();

            #endregion
            #endregion
            #region -B.Çoklu Veri Çekme-
            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //uzm_nationality Ulus = NationalityList.Where(i => i.uzm_name == wantedNationality).FirstOrDefault();
      //uzm_workplacecity City = WorkplaceList.Where(i => i.uzm_name == wantedCity).FirstOrDefault();
            #endregion
            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-

      //uzm_nationality Ulus = (from I in NationalityList
      //                        where I.uzm_name == wantedNationality
      //                        select I).FirstOrDefault();
      //uzm_workplacecity City = (from I in WorkplaceList
      //                          where I.uzm_name == wantedCity
      //                          select I).FirstOrDefault();

            #endregion
            #endregion

      //Guid ulusid = nationalityOne.Id;
      //Guid cityid = workplaceOne.Id;
      //Console.WriteLine("\nGirmiş olduğunuz nationality bilgisinin name'i  {0} ve workplace bilgisinin name'i {1}'dır", nationalityOne.uzm_name, workplaceOne.uzm_name);
      //Console.WriteLine("\nİstemiş olduğunuz nationality bilgisinin ID'si  {0} ve workplace bilgisinin ID'si {1}'dır", ulusid, cityid);


            #endregion
            #region -CRM'de customers varlığına veri ekleme-
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer Customer = new uzm_customer();
      //Customer.uzm_customernumber = "123rt456";
      //Customer.uzm_nationalityid = new EntityReference("uzm_nationality", ulusid);//xrm.shemada  nationality lookup setleme
      //Customer.uzm_name = "Halimgemiyenytrew";//default mu bak
      //Customer.uzm_surname = "MIZRAKLI";
      //Customer.uzm_dateofbirth = new DateTime(1987, 5, 10);//Oğuzhana sor.Bugünün tarihinden yola çık.Doğum tarihini bul.
      //Customer.uzm_iscurrentsituation = new OptionSetValue(1);//1-Çalışıyor;2-Çalışmıyor verir.
      //Customer.uzm_iscompanysector = new OptionSetValue(1);//Birşeyler yazdım ona bak verir.
      //Customer.uzm_workplacecityid = new EntityReference("uzm_workplacecity", cityid);//Xrm.Shemada  workplace lookup setleme
      //Customer.uzm_ispermission = true;//two options
      //_xrmContext.AddObject(Customer);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
      //Console.WriteLine("Kayıt eklenmiştir.");
            #endregion
            #endregion
            #region -Ödev_16_uzm_customer,uzm_workplacecityid'yi[uzm_uzm_workplacecity_uzm_customer_workplacecityid] ve uzm_company[uzm_uzm_company_uzm_customer_companyid] Lookup Yapma,Option Setleme ve Kayıt Ekleme-
            #region -CRM'de natoanilities,workplacecities ve companis varlıkarından isimleri çekme-
      //string wantedNationality, wantedCity, companyName; ;
      //Console.Write("ID'sine ulaşmak  istediğiniz müşterinin nationality bilgisini giriniz:");
      //wantedNationality = Console.ReadLine();
      //Console.Write("Müşterinin ID'sine ulaşmak  istediğiniz şehrin workplacecity bilgisini giriniz:");
      //wantedCity = Console.ReadLine();
      //Console.Write("Müşterinin ID'sine ulaşmak  istediğiniz çalıştığı firmanın company name bilgisini giriniz:");
      //companyName = Console.ReadLine();
            #region -A.Tekli Veri Çekmek İçin-
            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //var nationalityOne = _xrmContext.uzm_nationalitySet.Where(i => i.uzm_name == wantedNationality).First();
      //var WorkplaceOne= _xrmContext.uzm_workplacecitySet.Where(i => i.uzm_name == wantedCity).First();           
      //var companyOne = _xrmContext.uzm_companySet.Where(i => i.uzm_name == companyName).First(); 
            #endregion
            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-
      //var nationalityOne = (from I in _xrmContext.uzm_nationalitySet
      //                      where I.uzm_name == wantedNationality
      //                      select I).First();
      //var WorkplaceOne = (from I in _xrmContext.uzm_workplacecitySet
      //                    where I.uzm_name == wantedCity
      //                    select I).First();
      //var companyOne = (from I in _xrmContext.uzm_companySet
      //                  where I.uzm_name == companyName
      //                  select I).First();

            #endregion
      //Guid ulusid = nationalityOne.Id;
      //Guid cityid = WorkplaceOne.Id;
      //Guid companyid = companyOne.Id;
      //Console.WriteLine("\nGirmiş olduğunuz nationality name: {0}, workplace name:{1} ve company name:{2}'dir", nationalityOne.uzm_name, WorkplaceOne.uzm_name, companyOne.uzm_name);
      //Console.WriteLine("\n İstemiş olduğunuz nationality  ID: {0}, workplace ID:{1} ve company ID:{2}'dir", ulusid, cityid, companyid);
            #endregion
            #region -B.Çoklu Veri Çekmek İçin-
      //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.ToList();
      //List<uzm_workplacecity> WorkplaceList = _xrmContext.uzm_workplacecitySet.ToList();
      //List<uzm_company> CompanyList = _xrmContext.uzm_companySet.ToList();
            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //uzm_nationality Ulus = NationalityList.Where(i => i.uzm_name == wantedNationality).FirstOrDefault();
      //uzm_workplacecity City = WorkplaceList.Where(i => i.uzm_name == wantedCity).FirstOrDefault();
      //uzm_company Company = CompanyList.Where(i => i.uzm_name == companyName).FirstOrDefault();
            #endregion
            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-

      //uzm_nationality Ulus = (from I in NationalityList
      //                        where I.uzm_name == wantedNationality
      //                        select I).FirstOrDefault();
      //uzm_workplacecity City = (from I in WorkplaceList
      //                          where I.uzm_name == wantedCity
      //                          select I).FirstOrDefault();
      //uzm_company Company = (from I in CompanyList
      //                       where I.uzm_name == companyName
      //                       select I).FirstOrDefault();
            #endregion
      //Guid ulusid = Ulus.uzm_nationalityId.Value;
      //Guid cityid = City.uzm_workplacecityId.Value;
      //Guid companyid = Company.uzm_companyId.Value;
      //Console.WriteLine("İstemiş olduğunuz nationality  ID: {0}, workplace ID:{1} ve company ID:{2}'dir", ulusid, cityid, companyid); //
            #endregion

            #endregion
            #region -CRM'de customers varlığına veri ekleme-
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer Customer = new uzm_customer();
      //Customer.uzm_nationalityid = new EntityReference("uzm_nationality", ulusid);
      //Customer.uzm_name = "Danyel Zlatan";
      //Customer.uzm_surname = "Zok";
      //Customer.uzm_dateofbirth = new DateTime(1987, 5, 10);
      //Customer.uzm_iscompanysector = new OptionSetValue(1);
      //Customer.uzm_companyid = new EntityReference("uzm_company", companyid);
      //Customer.uzm_workplacecityid = new EntityReference("uzm_workplacecity", cityid);
      //Customer.uzm_ispermission = true;
      //_xrmContext.AddObject(Customer);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
      //Console.WriteLine("\nKayıt eklenmiştir.");
            #endregion
            #endregion
            #region -Ödev_17_uzm_company ve uzm_employeeid'yi[uzm_uzm_employee_uzm_company_employeeid] Lookup Yapma,Option Setleme ve Kayıt Ekleme-
            #region -CRM'de employees varlığının ismini çekme-
      //string wantedEmployee;
      //Console.Write("ID'sine ulaşmak  istediğiniz çalışanın ad bilgisini giriniz:");
      //wantedEmployee = Console.ReadLine();

            #region -A.Tekli veri Çekmek için-
            #region - 1.YOL - Linq İşlemlerinin Metotla Sorgulanması -
      //var employee = _xrmContext.uzm_employeeSet.Where(i => i.uzm_name == wantedEmployee).First();
            #endregion
            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-
      //// var employee = (from I in _xrmContext.uzm_employeeSet
      //                 where I.uzm_name == wantedEmployee
      //                 select I).First();
            #endregion
      //Console.WriteLine("Aradığınız employee {0}'dir", employee.uzm_name);
      //Guid employeeid = employee.Id;
      //Console.WriteLine("Aradığınız employee  ID: {0}'dir", employeeid);
            #endregion

            #region -B.Çoklu Veri Çekmek İçin-
            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //uzm_employee Employee = EmployeeList.Where(i => i.uzm_name == wantedEmployee).FirstOrDefault();
      //Guid employeeid = Employee.uzm_employeeId.Value;
      // Console.WriteLine("Aradığınız employee  ID: {0}'dir", employeeid);
            #endregion
            #region -2.YOL - Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-
      ////uzm_employee Employee = (from I in EmployeeList
      ////                         where I.uzm_name == wantedEmployee
      ////                         select I).FirstOrDefault();
            #endregion
      //Guid employeeid = Employee.uzm_employeeId.Value;
      //Console.WriteLine("Aradığınız employee  ID: {0}'dir", employeeid);
            #endregion

            #endregion
            #region -CRM'de company varlığına veri ekleme-
      //List<uzm_company> CustomerList = _xrmContext.uzm_companySet.ToList();
      //uzm_company Company = new uzm_company
      //{
      //    uzm_name = "Marmara Birlik",
      //    uzm_iscategory = new OptionSetValue(2),
      //    uzm_employeeid = new EntityReference("uzm_employee", employeeid),
      //    uzm_numberofemployee = 5643
      //};
      //_xrmContext.AddObject(Company);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
            #endregion

            #endregion
            #endregion
            #region -Look_Up Yapma.1-
      //IOrganizationService service = GetService(); //TODO: Implement GetService()

      // //From: https://msdn.microsoft.com/en-us/library/gg328149.aspx

      // Entity contact = new Entity("City");
      // contact.Attributes["firstname"] = "Abdulvahap";
      // contact.Attributes["lastname"] = "Selçuk";
      // Guid contactId = service.Create(contact);

      // Entity account = new Entity("account");
      // account["name"] = "Test Account1";
      // EntityReference primaryContactId = new EntityReference("contact", contactId);
      // account["primarycontactid"] = primaryContactId;
            #endregion
            #region -Look_Up  Yapma_2_Xrm.Shema-

      //uzm_portaluser portalUser = new uzm_portaluser();
      //portalUser.uzm_name = "Alex de Souza";
      //Guid istanbulId = new Guid("EB148EFB-1A78-EA11-9009-606DC7F721EA");
      //portalUser.uzm_cityid = new EntityReference("uzm_city", istanbulId);
      //_xrmContext.AddObject(portalUser); 
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Option Setleme-
      //uzm_portaluser portalUser = new uzm_portaluser();
      //portalUser.uzm_name = "Tuncay Şanlı";
      //portalUser.uzm_isgender = new OptionSetValue(1);
      //_xrmContext.AddObject(portalUser);
      //var result = _xrmContext.SaveChanges();
            #endregion
            #region -Lambda Expression Order By Kullanımı -
      //CRM'de nationalities varlığından veri çekip sıralama ve listeleme
      //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.ToList();//Kayıtlı ulusları id'larıyla beraber  getirir.
      // List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.OrderBy(x=>x.uzm_nationalityId).ToList();//Id'ye göre sıralama yapar.
      // List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.OrderBy(x => x.uzm_name).ToList();//uzm_name göre sıralama yapar.
      // List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.OrderByDescending(x => x.uzm_name).ToList();//uzm_name göre tersten sıralama yapar.
      //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.OrderBy(x => x.uzm_nationalityId).ThenBy(x => x.uzm_name).ToList();//uzm_name ve uzm_nationalityId'ye göre sıralama yapar.
      //foreach (var ulus in NationalityList)
      //{
      //    //Console.WriteLine("Nation Id:{0} Nation Name:{1}",ulus.uzm_nationalityId,ulus.uzm_name);
      //    Console.WriteLine(string.Format("Id:{0}  Adı:{1}", ulus.uzm_nationalityId, ulus.uzm_name));
            #endregion
            #region -Lambda Expression Skip ve Take Kullanımı -
      //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.OrderBy(x => x.uzm_nationalityId).Skip(9).Take(5).ToList();//İlk 9 nationality'i geçiyor.Son 3 ünü alıyor.' tane de yok.Onu boş geçiyor.
      //foreach (var ulus in NationalityList)
      //{
      //    Console.WriteLine(string.Format("Id:{0}  Adı:{1}", ulus.uzm_nationalityId, ulus.uzm_name));
      //}
            #endregion
            #region -Lambda Expression Select Kullanımı -
            #region -1.Lambda Expression Select ile Sadece bir alan dödürme-
      //List<string> CustomerName = _xrmContext.uzm_customerSet.Select(x => x.uzm_name).ToList();//Sadece  CustomerName döndürür.
      //foreach (var musteriAdi in CustomerName)
      //{
      //    Console.WriteLine(musteriAdi);
      //}
            #endregion
            #region -2.Linq Select ile Sadece bir alan dödürme-
      //List<uzm_customer > CustomerName = (from cust in _xrmContext.uzm_customerSet
      //                             select new uzm_customer()
      //                             {
      //                                 uzm_dateofbirth = cust.uzm_dateofbirth,
      //                             }
      //                                    ).ToList();//1 tane  alan döndürür.
      //foreach (uzm_customer musteri in CustomerName)
      //{
      //    Console.WriteLine("DoğumTarihi:{0}", musteri.uzm_dateofbirth);
      //}
            #endregion

            #region -Çoklu Alan Döndürme-
      //List<uzm_customer> CustomerName = _xrmContext.uzm_customerSet.Select(x => new uzm_customer() {
      //    uzm_name = x.uzm_name,
      //    uzm_surname = x.uzm_surname,
      //    uzm_age = x.uzm_age,
      //    uzm_dateofbirth = x.uzm_dateofbirth }).ToList();//4 tane ayrı alan döndürür.

      //foreach (var musteri in CustomerName)
      //{
      //    Console.WriteLine("Adı:{0} Soyadı:{1} Yaşı:{2} DoğumTarihi:{3}", musteri.uzm_name, musteri.uzm_surname,musteri.uzm_age,musteri.uzm_dateofbirth);
      //}
            #endregion
            #region -1.Lambda Expression Select ile Çoklu Alan Döndürme_Classİle_-
      //List<CustomersMini> CustomerName = _xrmContext.uzm_customerSet.Select(x => new CustomersMini()
      //{
      //    uzm_name = x.uzm_name,
      //    uzm_surname = x.uzm_surname,
      //    uzm_age = x.uzm_age,
      //    uzm_dateofbirth = x.uzm_dateofbirth,
      //}).ToList();//4 tane ayrı alan döndürür.

      //foreach (CustomersMini musteri in CustomerName)
      //{
      //    Console.WriteLine("Adı:{0} Soyadı:{1} Yaşı:{2} DoğumTarihi:{3}", musteri.uzm_name, musteri.uzm_surname, musteri.uzm_age, musteri.uzm_dateofbirth);
      //}
            #endregion
            #region -2.Linq ile Çoklu Alan Döndürme_Classİle_-
      //List<CustomersMini> CustomerName = (from cust in _xrmContext.uzm_customerSet
      //                                    select new CustomersMini()
      //                                    {
      //                                        uzm_name = cust.uzm_name,
      //                                        uzm_surname = cust.uzm_surname,
      //                                        uzm_age = cust.uzm_age,
      //                                        uzm_dateofbirth = cust.uzm_dateofbirth,
      //                                    }
      //                                    ).ToList();//4 tane ayrı alan döndürür.

      //foreach (CustomersMini musteri in CustomerName)
      //{
      //    Console.WriteLine("Adı:{0} Soyadı:{1} Yaşı:{2} DoğumTarihi:{3}", musteri.uzm_name, musteri.uzm_surname, musteri.uzm_age, musteri.uzm_dateofbirth);
      //}
            #endregion
            #endregion
            #region -1.Lambda Expression Count Kullanımı-
            #region -1.a-
      //List<uzm_customer> CustomerName = _xrmContext.uzm_customerSet.ToList();
      //Console.WriteLine("Arama sonucunda  " + CustomerName.Count(x => x.uzm_name == "Halit") + "  tane kayıt bulunmuştur");
            #endregion
            #region -2.a-
      //List<uzm_customer> CustomerName = _xrmContext.uzm_customerSet.ToList();
      //string arananaKişi = "";
      //do
      //{
      //    Console.Write("Aramak istediğiniz kişiyi giriniz:");
      //    arananaKişi = Console.ReadLine();
      //    int adet = CustomerName.Count(x => x.uzm_name.Contains(arananaKişi));
      //    Console.WriteLine("Arama sonucunda  " + adet + "  tane kayıt bulunmuştur");
      //} while (arananaKişi != "exit");

            #endregion
            #endregion
            #region -2.Lambda Expression Any Kullanımı-

      //List<uzm_customer> CustomerName = _xrmContext.uzm_customerSet.ToList();
      //string musteri;
      //do
      //{
      //    Console.Write("Müşteri adını giriniz:");
      //    musteri = Console.ReadLine();
      //    if (CustomerName.Any(x => x.uzm_name == musteri))
      //    {

      //        Console.WriteLine("Arama sonucunda bir tane kayıt bulunmuştur");  
      //    }
      //    else
      //    {
      //        Console.WriteLine("Personel bulunamadı.");
      //    }
      //} while (musteri!="exit");
            #endregion
            #region -Veri Ekleme_1-
      //Console.WriteLine("Eklemek istediğiniz müşterinin adını giriniz:");
      //string adi = Console.ReadLine();
      //Console.WriteLine("Eklemek istediğiniz müşterinin soyadını giriniz:");
      //string soyadi = Console.ReadLine();
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer Customer = new uzm_customer();
      //Customer.uzm_name = adi;
      //Customer.uzm_surname = soyadi;
      //_xrmContext.AddObject(Customer);
      //Console.WriteLine("{0} {1}", Customer.uzm_name, Customer.uzm_surname);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
      //Console.WriteLine("Kayıt eklenmiştir");
            #endregion
            #region -Veri Ekleme_2-
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer Customer = new uzm_customer();
      //Customer.uzm_name = "Daniel";
      //Customer.uzm_surname = "Defone";
      //_xrmContext.AddObject(Customer);
      //Console.WriteLine("{0} {1}", Customer.uzm_name, Customer.uzm_surname);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
      //Console.WriteLine("Kayıt eklenmiştir");
            #endregion
            #region -Veri Güncellemek İçin-
      //Console.WriteLine("Müşterinin güncel adı:");
      //string adi = Console.ReadLine();
      //Console.WriteLine("Müşterinin güncel soyadı:");
      //string soyadi = Console.ReadLine();
      //Console.WriteLine("Müşterinin yaşi:");
      //int yasi = Convert.ToInt32(Console.ReadLine());
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer custr = CustomerList.Where(m => m.uzm_name == "Hasan").FirstOrDefault();
      //custr.uzm_name = adi;
      //custr.uzm_surname = soyadi;
      //custr.uzm_age = yasi;
      //_xrmContext.UpdateObject(custr);
      //Console.WriteLine("{0} {1}", custr.uzm_name, custr.uzm_surname);
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
      //Console.WriteLine("Veri güncellenmiştir");
            #endregion
            #region -Silmek için-
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //uzm_customer custr = CustomerList.Where(m => m.uzm_name == "Halit").FirstOrDefault();
      //_xrmContext.DeleteObject(custr); ;
      //SaveChangesResultCollection result = _xrmContext.SaveChanges();
      //Console.WriteLine("Veri silinmiştir");


            #endregion

            #region -Udemy'den Örnek Uygulamalar-
            #region -A ile başlayan müşterilerin adedini veriniz.-
      /*1_KLASİK YÖNTEMLE BULMA*/
      // char harf;
      // int bulunanToplam = 0;
      // Console.Write("Sayısını bumak istediğiniz müşterinin isminin ilk harfini giriniz:");
      // harf = Convert.ToChar(Console.ReadLine());
      // List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //// uzm_customer Customer = new uzm_customer();
      // for (int i = 0; i < CustomerList.Count; i++)
      // {
      //     if (CustomerList[i].uzm_name[0] == harf)
      //     {
      //         bulunanToplam++;
      //     }

      // }
      // Console.WriteLine("Sistemimizde ilk harfi  {0} ile başlayan kayıtlı toplam müşteri sayısı {1}'dir", harf, bulunanToplam);
      // Console.WriteLine(CustomerList.Count);

      /*2_Linq Where SORGULAMA İLE BULMA*/
      //string harf;
      //Console.Write("Sayısını bumak istediğiniz müşterinin isminin ilk harfini giriniz:");
      //harf = Console.ReadLine();
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //int bulunanToplam = CustomerList.Where(i => i.uzm_name.StartsWith(harf)).Count();
      //Console.WriteLine("Sistemimizde ilk harfi  {0} ile başlayan kayıtlı toplam müşteri sayısı {1}'dir", harf, bulunanToplam);
      //Console.WriteLine(CustomerList.Count);
            #endregion
            #region -Linq SorgulamaÇeşitleri-
            #region -1.YOL-Linq İşlemlerinin Metotla Sorgulanması-
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      //int bulunanToplam = CustomerList.Where(i => i.uzm_name.StartsWith ("A")).Count();
      //Console.WriteLine("Sistemimizde ilk harfi  A ile başlayan kayıtlı toplam müşteri sayısı {0}'dir",  bulunanToplam);
      //Console.WriteLine(CustomerList.Count);
            #endregion
            #region -2.YOL-Linq To Query Sorgusu(Bu sorgu biraz daha SQL sorgusuna yakındır)-
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
            #region -a.Hızlı Sonuç-
      //var BulunanToplam= (from I in CustomerList
      //                   where I.uzm_name.StartsWith("A")
      //                   select I).Count();

            #endregion
            #region -b.Yavaş Sonuç-
      //var BulunanToplam1 = from I in CustomerList
      //                     where I.uzm_name.StartsWith("A")
      //                     select I;
      //int BulunanToplam2 = BulunanToplam1.Count();
            #endregion
            #endregion

            #region -Alıştırmalar-
      // //1.CustomerList içerisinde isim değeri A ile başlayan müşterileri Linq to metot kullanarak bulalım.
      //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      // //int BulunanToplam = CustomerList.Where(i => i.uzm_name.StartsWith("A")).Count();
      // IEnumerable<uzm_customer> CustomerListAlıstirma1 = CustomerList.Where(i => i.uzm_name.StartsWith("A"));// IEnumerable sorgunun koleksiyona gittiğini,yapıldığını ve bittiğini ifade eder.
      // Console.WriteLine(CustomerListAlıstirma1.Count());
      // //2.CustomerList içerisinde isim son değeri A ile biten müşterileri Linq to metot kullanarak bulalım.
      // List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      // int BulunanToplam = CustomerList.Where(i => i.uzm_name.EndsWith("A")).Count();
      ///* IEnumerable<uzm_customer> CustomerListAlıstirma1 = CustomerList.Where(i => i.uzm_name.EndsWith("A"));*/// IEnumerable sorgunun koleksiyona gittiğini,yapıldığını ve bittiğini ifade eder.
      // Console.WriteLine(BulunanToplam);

      //3.CustomerList içerisinde isimin herhangi değeri A olan müşterileri Linq to metot kullanarak bulalım.
      // List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
      /*3.a*/
      // int BulunanToplam = CustomerList.Where(i => i.uzm_name.Contains("a")).Count();
      //Console.WriteLine(BulunanToplam);
      /*3.b*/
      //List<uzm_customer> BulunanToplam = CustomerList.Where(i => i.uzm_name.Contains("a")).ToList();
      //Console.WriteLine(BulunanToplam.Count());
      /*3.d*/
      //var BulunanToplam = CustomerList.Where(i => i.uzm_name.Contains("a")).ToList();
      //Console.WriteLine(BulunanToplam.Count());
      /*3.e*/
      //IEnumerable<uzm_customer> CustomerListAlıstirma1 = CustomerList.Where(i => i.uzm_name.Contains("A"));// IEnumerable sorgunun koleksiyona gittiğini,yapıldığını ve bittiğini ifade eder.
      //Console.WriteLine(CustomerListAlıstirma1.Count());
      //4.CustomerList içerisindeki kayıtlardan isiminin  herhangi değeri t olan VE/VEYA meslek değeri içinde M değeri geçen müşterileri Linq to metot kullanarak bulalım.

      //var BulunanToplam = CustomerList.Where(I => I.uzm_name.Contains("t") && I.uzm_profession.Contains("M")).ToList();//Burda sorun var bir ara bak.
      //Console.WriteLine(BulunanToplam.Count);
      //5.CustomerList içerisindeki kayıtlardan doğum yılı 1990'dan büyük olan ve   isiminin  herhangi değeri a olan müşterileri 2.yol olan Linq to Query  ile bulalım...
      //var BulunanToplam = from I in CustomerList
      //                    where I.uzm_placeofbirth == "Istanbul" && I.uzm_name.Contains("a")//I.uzm_placeofbirth.Year>1990 işlemini yaptıramıyorum.Bir bak.
      //                    select I;
      //Console.WriteLine(BulunanToplam.Count());
      //6.CustomerList içerisindeki kayıtlardan doğum yılı 1990'dan büyük olan veya   isiminin  herhangi değeri a olan müşterileri 2.yol olan Linq to Query  ile bulalım...
      //int sayac=0;
      //var BulunanToplam = from I in CustomerList
      //                    where I.uzm_placeofbirth == "Istanbul" || I.uzm_name.Contains("a")//I.uzm_placeofbirth.Year>1990 işlemini yaptıramıyorum.Bir bak.
      //                    select I;
      //foreach (uzm_customer musteri in BulunanToplam)
      //{
      //    sayac++;
      //    Console.WriteLine("{0}.Müşterinin adı:{1} müşterinin soyadı:{2}", sayac, musteri.uzm_name,musteri.uzm_surname);
      //}
      //Console.WriteLine("Bu arama kriterleri ile eşleşen müşteri sayısı  "+ sayac +"'dir/dur/tır/tur");


            #endregion

            #endregion

            #endregion



     


            Console.ReadKey();

        }


    }
}
