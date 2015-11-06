using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// UI - User Interface 화면을 구성하는 다양한 요소들
// (글자, 입력박스, 버튼, 스크롤...)
namespace Unity.UI
{
	// 규격문서 (보통 I로 시작) - 버튼을 사용하기 위해 필히 이용해야 하는 규격.
	interface IButtonEvent
	{
		void ButtonClicked(); // 이렇게 만들라고 요청 (접근제어자는 설정하지 않음)
	}

	// 버튼 클래스 사용법.
	// Button을 생성 후 해당 객체의 target에
	// IButtonEvent를 상속받아 기능을 구현한 객체를 넣어주세요.
	// 버튼이 클릭될 때 해당 기능이 수행됩니다.
	class Button
	{
		public IButtonEvent target;

		public void Click()
		{
			// 받은 객체에게 버튼 클릭 명령을 내린다.
			target.ButtonClicked();

			Console.WriteLine("버튼이 클릭됨.");
		}
	}
}
