using PerpustakaanAppMVC.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanAppMVC.Model.Repository
{
    class MahasiswaRestApiRepository
    {
		public int Create(Mahasiswa mhs)
		{
			string baseUrl = "http://latihan.buatdevelop.com:5555/";
			var endpoint = "api/mahasiswa";

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.POST); ;

			// tambahkan objek mahasiswa ke dalam body
			request.AddJsonBody(mhs);

			// request ke server
			var response = client.Execute(request);

			// cek nilai content, jika 1 berhasil selain itu gagal
			var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
			return result;

		}

		public int Update(Mahasiswa mhs)
		{
			string baseUrl = "http://latihan.buatdevelop.com:5555/";
			var endpoint = "api/mahasiswa/" + mhs.Npm;

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.PUT); ;

			// tambahkan objek mahasiswa ke dalam body
			request.AddJsonBody(mhs);

			// request ke server
			var response = client.Execute(request);

			// cek nilai content, jika 1 berhasil selain itu gagal
			var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
			return result;
		}

		public int Delete(Mahasiswa mhs)
		{
			string baseUrl = "http://latihan.buatdevelop.com:5555/";
			var endpoint = "api/mahasiswa/"+mhs.Npm;

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.DELETE); 

			// tambahkan objek mahasiswa ke dalam body
			//request.AddJsonBody(mhs);

			// request ke server
			var response = client.Execute(request);

			// cek nilai content, jika 1 berhasil selain itu gagal
			var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
			return result;
		}

		public List<Mahasiswa> ReadAll()
		{
			string baseUrl = "http://latihan.buatdevelop.com:5555/";
			string endpoint = "api/mahasiswa";

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.GET);

			// kirim request ke server
			var response = client.Execute<List<Mahasiswa>>(request);

			return response.Data;
		}

		public List<Mahasiswa> ReadByNama(string nama)
		{
			string baseUrl = "http://latihan.buatdevelop.com:5555/";
			string endpoint = "api/mahasiswa?name="+nama ;

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.GET);

			// kirim request ke server
			var response = client.Execute<List<Mahasiswa>>(request);

			return response.Data;
		}

		public Mahasiswa ReadByNpm(string npm)
		{
			throw new NotImplementedException();
		}
	}
}
