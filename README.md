# load_net8_com_from_net48
.NET4.8 から .NET8のCOMコンポーネントを呼び出す最小サンプル

.NET8側のdllコンパイル。

管理者権限で 
```cmd
regsvr32 ClassLibrary12.comhost.dll
```

.NET4.8側(ConsoleApp側)から呼び出し。
intefaceの在り方がCoClassなど使ってちょっとめんどくさいので注意

プロジェクトの設定に
&lt;ApplicationManifest&gt;App.manifest&lt;/ApplicationManifest&gt;
みたいな項目があるのに注意