using Zenject;

public class GameStateInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        var model = new StateModel();
        var controller = new StateController(model);
        
        Container
            .Bind<IStateController>()
            .FromInstance(controller)
            .AsSingle();
    }
}