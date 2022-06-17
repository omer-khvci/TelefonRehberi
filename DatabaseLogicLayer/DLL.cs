using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValues;
        public DLL()
        {
            con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=TelefonRehberi;Integrated Security=True;");
        }
        public void BaglantiAyarla()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
           
        }
        public int KayitEkle(Rehber rehber)
        {
            try
            {
                cmd= new SqlCommand("insert into Rehber(ID,Isim,Soyisim,TelefonNumarasiI,TelefonNumarasiII,TelefonNumarasiIII,EmailAdres,WebAdres,Adres,Aciklama) values (@ID,@Isim,@Soyisim,@TelefonNumarasiI,@TelefonNumarasiII,@TelefonNumarasiIII,@EmailAdres,@WebAdres,@Adres,@Aciklama)");
                cmd.Parameters.Add("@ID",System.Data.SqlDbType.UniqueIdentifier).Value=rehber.ID;
                cmd.Parameters.Add("@Isim", System.Data.SqlDbType.NVarChar).Value = rehber.Isim;
                cmd.Parameters.Add("@Soyisim", System.Data.SqlDbType.NVarChar).Value = rehber.Soyisim;
                cmd.Parameters.Add("@TelefonNumarasiI", System.Data.SqlDbType.NVarChar).Value = rehber.TelefonNumarasiI;
                cmd.Parameters.Add("@TelefonNumarasiII", System.Data.SqlDbType.NVarChar).Value = rehber.TelefonNumarasiII;
                cmd.Parameters.Add("@TelefonNumarasiIII", System.Data.SqlDbType.NVarChar).Value = rehber.TelefonNumarasiIII;
                cmd.Parameters.Add("@EmailAdres", System.Data.SqlDbType.NVarChar).Value = rehber.EmailAdres;
                cmd.Parameters.Add("@Adres", System.Data.SqlDbType.NVarChar).Value = rehber.Adres;
                cmd.Parameters.Add("@Aciklama", System.Data.SqlDbType.NVarChar).Value = rehber.Aciklama;
                BaglantiAyarla();
                ReturnValues= cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }

            return ReturnValues;
        }
        public int SistemKontrol(Kullanici K)
        {
            try
            {
                cmd = new SqlCommand("select count(*) from Kullanici where KullaniciAdi = @KullaniciAdi and Sifre =@Sifre", con);
                cmd.Parameters.Add("@KullaniciAdi", System.Data.SqlDbType.NVarChar).Value = K.KullaniciAdi;
                cmd.Parameters.Add("@Sifre", System.Data.SqlDbType.NVarChar).Value = K.Sifre;
                BaglantiAyarla();
                ReturnValues = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }
        public int KayitDuzenle(Rehber rehber)
        {
            try
            {
                cmd = new SqlCommand(@"update Rehber RehberIsim=@Isim,Soyisim=@Soyisim,TelefonNumarasiI=@TelefonNumarasiI,TelefonNumarasiII=@TelefonNumarasiII,TelefonNumarasiIII=@TelefonNumarasiIII,EmailAdres=@EmailAdres,WebAdres=@WebAdres,Adres=@Adres,Aciklama=@Aciklama",con);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = rehber.ID;
                cmd.Parameters.Add("@Isim", System.Data.SqlDbType.NVarChar).Value = rehber.Isim;
                cmd.Parameters.Add("@Soyisim", System.Data.SqlDbType.NVarChar).Value = rehber.Soyisim;
                cmd.Parameters.Add("@TelefonNumarasiI", System.Data.SqlDbType.NVarChar).Value = rehber.TelefonNumarasiI;
                cmd.Parameters.Add("@TelefonNumarasiII", System.Data.SqlDbType.NVarChar).Value = rehber.TelefonNumarasiII;
                cmd.Parameters.Add("@TelefonNumarasiIII", System.Data.SqlDbType.NVarChar).Value = rehber.TelefonNumarasiIII;
                cmd.Parameters.Add("@EmailAdres", System.Data.SqlDbType.NVarChar).Value = rehber.EmailAdres;
                cmd.Parameters.Add("@Adres", System.Data.SqlDbType.NVarChar).Value = rehber.Adres;
                cmd.Parameters.Add("@Aciklama", System.Data.SqlDbType.NVarChar).Value = rehber.Aciklama;
                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }
        public int KayitSil(Guid ID)
        {
            try
            {
                cmd = new SqlCommand(@"delete Rehber where ID=@ID", con);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = ID;
                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }
        public SqlDataReader KayitListe()
        {
            cmd = new SqlCommand("Select * from Rehber",con);
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }
        public SqlDataReader KayitListeID(Guid ID)
        {
            cmd = new SqlCommand("Select * from Rehber where ID=@ID", con);
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value=ID;
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }
    }
   
}
