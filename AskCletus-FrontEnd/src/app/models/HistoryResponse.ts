export interface HistoryResponse {
    DrinkId: number
    DateTime: string
        userId: number
    }
    
    export type PostHistory = Omit<HistoryResponse, "ingredientsId">;


