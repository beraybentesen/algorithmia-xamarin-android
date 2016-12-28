Algorithmia Xamarin Android Client
=====

Android resource: https://github.com/algorithmiaio/algorithmia-android

Version : 1.0.1

Download : Available on Nuget Gallery (https://www.nuget.org/packages/Algorithmia.Xamarin/1.0.1)

How do I use Algorithmia ?
-------------------

AsyncTask helper to make it easy to call Algorithmia in the background. 

Note : example with async / await with Task class is coming soon for better optimization. 
 
```cs
public class AlgorithmiaTask : AsyncTask<string, string, AlgoResponse>
	{
		static string TAG = "AlgorithmiaTask";
		public string algoUrl;
		AlgorithmiaClient client;
		Algorithm algo;

		public AlgorithmiaTask(string api_key, string algoUrl)
		{
			this.algoUrl = algoUrl;
			client = Algorithmia.Client(api_key);
			algo = client.Algo(algoUrl);
		}

		protected override AlgoResponse RunInBackground(params string[] @params)
		{
			if (@params.Length == 1)
			{
				string input = @params[0];
				// Call algorithmia
				try
				{
					AlgoResponse response = algo.Pipe(input);
					Console.WriteLine(response.AsString());
					return response;
				}
				catch (APIException e)
				{
					// Connection error
					Log.Error(TAG, "Algorithmia API Exception", e);
					return null;
				}
			}
			else {
				// Too many inputs
				return null;
			}
		}
	}
```

 Execute Task

```cs
		new AlgorithmiaTask("simCI3b2pnGDwdxK1XnHrET1bbr1", "algo://demo/Hello/0.1.1").Execute("HAL 9000");
```

Response should be -> Hello HAL 9000



Author
------
Beray Bentesen -  @BerayBentesen on Twitter




