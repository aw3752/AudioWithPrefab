# AudioWithPrefab
 오디오를 프리팹으로 저장해 유니티 내에서 볼륨/피치 조절

## 사용 방법
1. AudioManager.cs이 씬 안에 굴러가도록 gameObject에 꽂기.
2. AudioSourcePrefabFrame을 상속받은 프리팹에 AudioStream을 꽂고 저장.
2-1. 해당 프리팹의 AudioSource 컴포넌트의 Pitch 영역으로 피치 조절.
2-2. 2-1. 해당 프리팹의 AudioSourcePrefab 컴포넌트의 Original Volume 영역으로 소리 크기 조절.
3. AudioManager.Instance.Play에 AudioSourcePrefabFrame 배리언트 프리팹을 인자로 넘기고 플레이.

## AudioWithPrefab.unitypackage 내용물
코드와 데모