# CmdNoWin

윈도우 없이 명령 프롬프트에서 명령 실행하기

## 사용 방법 1: 지정한 명령 실행

```batch
:: CmdNoWin.exe <명령> [<파라미터> ...]
CmdNoWin.exe dir /s /b ..
```

## 사용 방법2: 특정 파일 실행

1. 폴더 생성
1. 폴더 안에 `CmdNoWin.exe`를 복사
1. `CmdNoWin.exe` 파일명을 원하는 이름으로 변경 (`some.exe`)
1. `_some.run.cmd` 파일을 생성하여 원하는 스크립트 작성
1. `some.exe`를 실행하면 `_some.run.cmd` 가 실행됨


## Usage Method 1: Execute a Specified Command

```batch
:: CmdNoWin.exe <command> [<parameter> ...]
CmdNoWin.exe dir /s /b ..
```

## Usage Method 2: Execute a Specific File

1. Create a folder
1. Copy `CmdNoWin.exe` into the folder
1. Rename `CmdNoWin.exe` to your desired name (`some.exe`)
1. Create a `_some.run.cmd` file and write your desired script
1. When you run `some.exe`, `_some.run.cmd` will be executed.
   ```batch
   some.exe [parameter ...]
   ```
