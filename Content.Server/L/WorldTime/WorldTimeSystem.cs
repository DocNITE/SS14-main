namespace Content.Server.L.WorldTime;

public class WorldTimeSystem : EntitySystem
{

    public override void Initialize()
    {
        base.Initialize();

        //SubscribeLocalEvent<ImplanterComponent, ComponentInit>(OnImplanterInit);
        //SubscribeLocalEvent<ImplanterComponent, EntInsertedIntoContainerMessage>(OnEntInserted);
        //SubscribeLocalEvent<ImplanterComponent, ExaminedEvent>(OnExamine);
    }

    public override void Update(float frameTime)
    {
        base.Update(frameTime);
    }

}
