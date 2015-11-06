using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.UI;

namespace CSInterface
{
	class ButtonEvent : IButtonEvent
	{
		// 인터페이스가 시키는 메서드를 만들어 구현한다.
		public void ButtonClicked()
		{
			Console.WriteLine("회원정보를 갱신했습니다.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Alt+F12 누르면 설명 나옴. (설명의 IButtonEvent에서 또 Alt+F12눌러서 확인함)
			// 설명중 IButtonEvent을 보면 상속하고 해당 메서드 구현
			Button myBtn = new Button();

			// 규격문서를 적용한 객체를 전달한다.
			// static 클래스가 아니면 myBtn.target = this 로 하면 됨.
			myBtn.target = new ButtonEvent();

			myBtn.Click();
		}

	}
}
