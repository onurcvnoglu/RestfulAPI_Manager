# RestfulAPI_Manager
A library for call RESTful web service.


Simple use : 

  1. add to your project RestfulApi.Manager.Client.dll as reference.
  2. call -> RestfulApi.Manager.Client.ApiServiceClient<T> client = new RestfulApi.Manager.Client.ApiServiceClient<T>("url");
  3. get result -> var result = client.Get();
 
 Note : T is a object class you want to convert.
 
 #Example response : 
 {
  "userId": 1,
  "id": 1,
  "title": "delectus aut autem",
  "completed": false
}



#Example object class : 

public class Tester

    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
