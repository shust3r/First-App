import { IActivity } from "./IActivity";

export interface ICard {
    id?: number;
    name: string;
    description: string;
    dueDate?: Date;
    priority: number;
    listId?: number;
    activities?: IActivity[];
}