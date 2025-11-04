# Ver 1.0

2025-10-10 05:39:20

录制完了演示视频。

# Ver 1.1

Ver1.1：2025-10-24 22:28:44 修改项目、程序集、命名空间、类的名称



2025-11-4 08:52:41：

将 `DAL` 项目的 `OwnerRepository.cs` 中的 `Edit()` 修改为：

```cs
context.Entry(newOwner).State = EntityState.Modified;
```

