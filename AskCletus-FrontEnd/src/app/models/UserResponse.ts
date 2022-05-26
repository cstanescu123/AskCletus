import { IngredientsResponse } from "./IngredientsResponse";
    export interface UserResponse {
        userId: number;
        userName: string;
        email: string;
        token: string;
        ingredients: IngredientsResponse[];
    }
    
    
    export type PostUser = Omit<UserResponse, "userId">;