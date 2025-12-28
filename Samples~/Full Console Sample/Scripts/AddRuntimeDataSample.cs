using Plugins.DebugSystem.Console.Extensions;
using Plugins.DebugSystem.RuntimeData;
using UnityEngine;

namespace DebugSystem.Console.Samples.FullConsoleSample
{
	public class AddRuntimeDataSample : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F1))
			{
				FindObjectOfType<LiveFeed>().AddRetriever(GetRandomInfo);
			}
			else if (Input.GetKeyDown(KeyCode.F3))
			{
				FindObjectOfType<LiveFeed>().RemoveRetriever(GetRandomInfo);
			}
			if (Input.GetKeyDown(KeyCode.F2))
			{
				FindObjectOfType<LiveFeed>().AddRetriever(GetRandomInfo2);
			}
			else if (Input.GetKeyDown(KeyCode.F4))
			{
				FindObjectOfType<LiveFeed>().RemoveRetriever(GetRandomInfo2);
			}
		}

		private string GetRandomInfo() => $"{"test:".Colored(Color.green)} time = {Time.time.ToString().Colored(Color.red)}";
		private string GetRandomInfo2() => $"{"test:".Colored(new Color(.5f, 1, 0))} deltaTime = {Time.deltaTime.ToString().Colored(Color.red)}";
	}
}